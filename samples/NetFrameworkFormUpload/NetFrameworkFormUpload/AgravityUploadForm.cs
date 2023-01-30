
using AgravityPublicLib;
using AgravityPublicUpload.Properties;
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

        private string createAssetFile { get; set; }
        private string createVersionFile { get; set; }
        private bool createVersionAssetReady { get; set; }
        private bool loadAssetReadiness { get; set; }
        public AgravityUploadForm()
        {
            InitializeComponent();
            dam = new AgravityDam(Settings.Default.AgravityPublicUrl, Settings.Default.AgravityApiKey);

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
                createAssetFile = openFileDialog1.FileName;
                lbFileSelected.Text = createAssetFile;
                if (string.IsNullOrEmpty(tbAssetName.Text))
                {
                    tbAssetName.Text = Path.GetFileNameWithoutExtension(createAssetFile);
                }
                checkUploadButton();
            }
            else
            {
                createAssetFile = null;
                lbFileSelected.Text = "No file selected.";
                checkUploadButton();
            }
        }

        private void checkUploadButton()
        {
            btUploadAsset.Enabled = btUploadAssetStorage.Enabled = (!string.IsNullOrEmpty(createAssetFile) && !string.IsNullOrEmpty(tbAssetName.Text) && !string.IsNullOrEmpty(tbCollectionId.Text));
        }

        private void btUploadAsset_Click(object sender, EventArgs e)
        {
            btUploadAsset.Enabled = false;
            pbAssetUpload.Enabled = true;
            pbAssetUpload.Value = 1;
            var assetId = dam.UploadAssetFile(tbAssetName.Text, tbCollectionId.Text, createAssetFile);
            if (!string.IsNullOrEmpty(assetId))
            {
                AddOutput($"Asset {assetId} uploaded.");
                pbAssetUpload.Value = 100;
                createAssetFile = null;
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

            var asset = dam.UploadCreateAssetStorageRest(tbAssetName.Text, createAssetFile, tbCollectionId.Text);
            if (asset != null)
            {
                createAssetFile = null;
                tbAssetName.Text = "";
                lbFileSelected.Text = "No file selected.";
                pbAssetUpload.ForeColor = System.Drawing.Color.Green;
                pbAssetUpload.Value = 100;

                AddOutput($"Upload completed.");

                tbAssetId.Text = asset.Id;
                lAssetStatus.Text = "Processing...";
                createVersionAssetReady = false;
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
            var collIdNames = dam.GetAllCollections(Settings.Default.CollectionTypeId)?.Select(cb => new Collection(cb.Id, cb.Name)).ToList();
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
            var coll = dam.CreateCollection(tbCollName.Text, Settings.Default.CollectionTypeId);
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

        private void btVersionOpenDialog_Click(object sender, EventArgs e)
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
                createVersionFile = openFileDialog1.FileName;
                lVersionFile.Text = createVersionFile;
                checkVersionButton();
            }
            else
            {
                createVersionFile = null;
                lVersionFile.Text = "No file selected.";
                checkVersionButton();
            }
        }

        private void btCreateVersion_Click(object sender, EventArgs e)
        {
            createVersionAssetReady = false;
            checkVersionButton();
            lVersionFile.Text = "Processing version...";
            AddOutput($"Creating new version for asset {tbAssetId.Text}...");
            var versionedAsset = dam.UploadAssetVersionToStorageRest(tbAssetId.Text, createVersionFile);
            if (versionedAsset != null)
            {
                AddOutput($"Created new version for asset with number: {versionedAsset.VersionNr}!");
                createVersionFile = null;
                lVersionFile.Text = "No file selected.";
                btCheckAsset_Click(sender, e);
            }
            else
            {
                AddOutput($"Creating new version failed!");
            }
            checkVersionButton();
        }
        private void checkVersionButton()
        {
            btCreateVersion.Enabled = createVersionAssetReady && (!string.IsNullOrEmpty(createVersionFile) && !string.IsNullOrEmpty(tbAssetId.Text));
        }

        private void tbAssetId_TextChanged(object sender, EventArgs e)
        {
            checkVersionButton();
            btCheckAsset.Enabled = !string.IsNullOrEmpty(tbAssetId.Text);
        }

        private void btCheckAsset_Click(object sender, EventArgs e)
        {
            if (loadAssetReadiness)
            {
                AddOutput($"Asset not ready from last check!");
                return;
            }
            loadAssetReadiness = true;
            lAssetStatus.Text = "Checking status...";

            AddOutput($"Checking asset with id {tbAssetId.Text}...");

            createVersionAssetReady = false;
            if (!string.IsNullOrEmpty(tbAssetId.Text))
            {
                Agravity.Public.Model.Asset asset = null;
                try
                {
                    asset = dam.GetAsset(tbAssetId.Text);
                }
                catch (Exception)
                {
                    AddOutput($"Error on checking asset with id: {tbAssetId.Text}...");
                    lAssetStatus.Text = "Error";
                }
                if (asset != null)
                {
                    tbAssetName.Text = asset.Name;
                    switch (asset.Status)
                    {
                        case "I":
                        case "P":
                            {
                                lAssetStatus.Text = "Processing...";
                                break;
                            }
                        case "A":
                            {
                                lAssetStatus.Text = "Ready!";
                                createVersionAssetReady = true;
                                break;
                            }
                        default:
                            break;
                    }
                }
                else
                {
                    lAssetStatus.Text = "Unknown asset";
                }
            }
            else
            {
                lAssetStatus.Text = "Enter valid assetID";
            }
            loadAssetReadiness = false;
            AddOutput($"Done...");
        }
    }
}
