using AgravityPublicLib;
using AgravityPublicUpload.Properties;
using Azure.Storage.Blobs;
using NetFrameworkFormUpload.model;
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NetFrameworkFormUpload
{
    public partial class AgravityUploadForm : Form
    {
        public AgravityDam dam { get; set; }

        public StringBuilder Output { get; set; } = new StringBuilder();

        private string currentFile { get; set; }
        public AgravityUploadForm()
        {
            InitializeComponent();
            dam = new AgravityDam(Settings.Default.AgravityPublicUrl, Settings.Default.AgravityApiKey, Settings.Default.CollectionTypeId);

            AddOutput("Initialized Backend");

        }

        private void AddOutput(string text)
        {
            Output.AppendLine(text);
            rtbOutput.Text = Output.ToString();
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse Any Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "",
                Filter = "All files (*.*)|*.*",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                currentFile = openFileDialog1.FileName;
                lbFileSelected.Text = currentFile;
                if (string.IsNullOrEmpty(tbAssetName.Text))
                {
                    tbAssetName.Text = Path.GetFileNameWithoutExtension(currentFile);
                }
                checkUploadButton();
            }
            else
            {
                currentFile = null;
                lbFileSelected.Text = "No file selected.";
                checkUploadButton();
            }
        }

        private void checkUploadButton()
        {
            btUploadAsset.Enabled = btUploadAssetStorage.Enabled = (!string.IsNullOrEmpty(currentFile) && !string.IsNullOrEmpty(tbAssetName.Text) && !string.IsNullOrEmpty(tbCollectionId.Text));
        }

        private void btUploadAsset_Click(object sender, EventArgs e)
        {
            btUploadAsset.Enabled = false;
            pbAssetUpload.Enabled = true;
            pbAssetUpload.Value = 1;
            var assetId = dam.UploadAssetFile(tbAssetName.Text, tbCollectionId.Text, currentFile);
            if (!string.IsNullOrEmpty(assetId))
            {
                AddOutput($"Asset {assetId} uploaded.");
                pbAssetUpload.Value = 100;
                currentFile = null;
                tbAssetName.Text = "";
                lbFileSelected.Text = "No file selected.";
            }
            else
            {
                AddOutput($"Asset failed.");
            }
            pbAssetUpload.Enabled = false;
            checkUploadButton();
        }

        private void btUploadAssetStorage_Click(object sender, EventArgs e)
        {
            btUploadAsset.Enabled = false;
            btUploadAssetStorage.Enabled = false;
            pbAssetUpload.Enabled = true;
            pbAssetUpload.ForeColor = System.Drawing.Color.Green;
            pbAssetUpload.Value = 1;
            var assetId = dam.CreateAsset(tbAssetName.Text, tbCollectionId.Text);
            if (!string.IsNullOrEmpty(assetId))
            {
                AddOutput($"Asset {assetId} created.");
                pbAssetUpload.Value = 15;

                var inboxToken = dam.GetInboxToken();

                var inboxContainer = new BlobContainerClient(new Uri(inboxToken.FullToken));

                var fileName = Path.GetFileName(currentFile);

                var uploadSucceded = inboxContainer.UploadBlob(fileName, new BinaryData(File.ReadAllBytes(currentFile)));

                if (uploadSucceded.GetRawResponse().Status == (int)System.Net.HttpStatusCode.Created)
                {
                    currentFile = null;
                    tbAssetName.Text = "";
                    lbFileSelected.Text = "No file selected.";
                    pbAssetUpload.ForeColor = System.Drawing.Color.Green;
                    pbAssetUpload.Value = 100;

                    AddOutput($"Upload completed.");
                }
                else
                {
                    pbAssetUpload.ForeColor = System.Drawing.Color.Red;
                    pbAssetUpload.Value = 100;
                    AddOutput($"Asset upload failed with status code {uploadSucceded.GetRawResponse().Status}.");
                }

                /*
                var client = new RestClient(new RestClientOptions(inboxToken.Url));

               
                string fileExtension = Path.GetExtension(currentFile);

                var uploadFileUrl = inboxToken.Container + $"/{fileName}" + inboxToken.Token;

                var request = new RestRequest(uploadFileUrl, Method.Put);
                request.AddHeader("x-ms-version", "2021-06-08");
                request.AddHeader("x-ms-date", DateTime.UtcNow.ToString("o"));
                request.AddHeader("x-ms-blob-type", "BlockBlob");
                request.AddHeader("x-ms-meta-assetid", assetId);

                // var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes(currentFile));

                string contentType;
                if (AgravityDam.ContentTypesDict.TryGetValue(fileExtension, out string cT))
                {
                    contentType = cT;
                }
                else
                {
                    // Content type was not found, default to "application/octet-stream"
                    contentType = "application/octet-stream";
                }
                request.AddHeader("Content-Type", contentType);

                // request.AddFile(fileName, currentFile);
                request.AddFile(fileName, currentFile);

                var response = client.ExecutePut(request);

                if (response.StatusCode == System.Net.HttpStatusCode.Created)
                {
                    currentFile = null;
                    tbAssetName.Text = "";
                    lbFileSelected.Text = "No file selected.";
                    pbAssetUpload.ForeColor = System.Drawing.Color.Green;
                    pbAssetUpload.Value = 100;

                    AddOutput($"Upload completed.");
                }
                else
                {
                    pbAssetUpload.ForeColor = System.Drawing.Color.Red;
                    pbAssetUpload.Value = 100;
                    AddOutput($"Asset upload failed with status code {response.StatusCode}.");
                }
                */
            }
            else
            {
                pbAssetUpload.ForeColor = System.Drawing.Color.Red;
                pbAssetUpload.Value = 100;
                AddOutput($"Asset failed.");
            }

            pbAssetUpload.Enabled = false;
            checkUploadButton();
        }

        private void tbCollectionId_TextChanged(object sender, EventArgs e)
        {
            checkUploadButton();
        }

        private void assetNameTb_TextChanged(object sender, EventArgs e)
        {
            checkUploadButton();
        }

        private void AgravityUploadForm_Load(object sender, EventArgs e)
        {
            var collIdNames = dam.GetAllCollections()?.Select(cb => new Collection(cb.Id, cb.Name)).ToList();
            listCollectionList.Items.Clear();
            if (collIdNames != null && collIdNames.Count > 0)
            {

                listCollectionList.Items.AddRange(collIdNames.ToArray());
            }
            else
            {
                listCollectionList.Items.Add("failed.");
            }
        }

        private void listCollectionList_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Collection obj in listCollectionList.SelectedItems)
            {
                tbCollectionId.Text = obj.Id;
                AddOutput($"Collection {obj.Id} selected.");
            }
        }

        private void btCollectionCreate_Click(object sender, EventArgs e)
        {
            var coll = dam.CreateCollection(tbCollName.Text);
            if (coll.Id != null)
            {
                listCollectionList.Items.Add(new Collection(coll.Id, coll.Name));
                AddOutput($"Collection {coll.Name} with ID: {coll.Id} created.");
                tbCollName.Text = "";
            }
            else
            {
                AddOutput($"Create collection failed.");
            }

        }

        private void tbCollName_TextChanged(object sender, EventArgs e)
        {
            btCollectionCreate.Enabled = !string.IsNullOrEmpty(tbCollName.Text);
        }
    }
}
