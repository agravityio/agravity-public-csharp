namespace NetFrameworkFormUpload
{
    partial class AgravityUploadForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgravityUploadForm));
            this.btUploadAsset = new System.Windows.Forms.Button();
            this.tbAssetName = new System.Windows.Forms.TextBox();
            this.lAssetName = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btOpenFile = new System.Windows.Forms.Button();
            this.lbFileSelected = new System.Windows.Forms.Label();
            this.listCollectionList = new System.Windows.Forms.ListBox();
            this.lbCollectionList = new System.Windows.Forms.Label();
            this.lCollectionId = new System.Windows.Forms.Label();
            this.tbCollectionId = new System.Windows.Forms.TextBox();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.lCollName = new System.Windows.Forms.Label();
            this.tbCollName = new System.Windows.Forms.TextBox();
            this.btCollectionCreate = new System.Windows.Forms.Button();
            this.lOutput = new System.Windows.Forms.Label();
            this.pbAssetUpload = new System.Windows.Forms.ProgressBar();
            this.btUploadAssetStorage = new System.Windows.Forms.Button();
            this.lAssetId = new System.Windows.Forms.Label();
            this.tbAssetId = new System.Windows.Forms.TextBox();
            this.lVersionFile = new System.Windows.Forms.Label();
            this.btVersionOpenDialog = new System.Windows.Forms.Button();
            this.btCreateVersion = new System.Windows.Forms.Button();
            this.lAssetStatus = new System.Windows.Forms.Label();
            this.btCheckAsset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btUploadAsset
            // 
            this.btUploadAsset.Enabled = false;
            this.btUploadAsset.Location = new System.Drawing.Point(351, 108);
            this.btUploadAsset.Name = "btUploadAsset";
            this.btUploadAsset.Size = new System.Drawing.Size(135, 23);
            this.btUploadAsset.TabIndex = 0;
            this.btUploadAsset.Text = "Upload Asset HTTP";
            this.btUploadAsset.UseVisualStyleBackColor = true;
            this.btUploadAsset.Click += new System.EventHandler(this.btUploadAsset_Click);
            // 
            // tbAssetName
            // 
            this.tbAssetName.Location = new System.Drawing.Point(424, 69);
            this.tbAssetName.Name = "tbAssetName";
            this.tbAssetName.Size = new System.Drawing.Size(203, 20);
            this.tbAssetName.TabIndex = 1;
            this.tbAssetName.TextChanged += new System.EventHandler(this.assetNameTb_TextChanged);
            // 
            // lAssetName
            // 
            this.lAssetName.AutoSize = true;
            this.lAssetName.Location = new System.Drawing.Point(351, 72);
            this.lAssetName.Name = "lAssetName";
            this.lAssetName.Size = new System.Drawing.Size(67, 13);
            this.lAssetName.TabIndex = 2;
            this.lAssetName.Text = "Asset Name:";
            // 
            // btOpenFile
            // 
            this.btOpenFile.Location = new System.Drawing.Point(351, 44);
            this.btOpenFile.Name = "btOpenFile";
            this.btOpenFile.Size = new System.Drawing.Size(74, 23);
            this.btOpenFile.TabIndex = 3;
            this.btOpenFile.Text = "Select";
            this.btOpenFile.UseVisualStyleBackColor = true;
            this.btOpenFile.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // lbFileSelected
            // 
            this.lbFileSelected.AutoEllipsis = true;
            this.lbFileSelected.Location = new System.Drawing.Point(434, 49);
            this.lbFileSelected.MaximumSize = new System.Drawing.Size(200, 0);
            this.lbFileSelected.Name = "lbFileSelected";
            this.lbFileSelected.Size = new System.Drawing.Size(200, 17);
            this.lbFileSelected.TabIndex = 4;
            this.lbFileSelected.Text = "No file selected.";
            this.lbFileSelected.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // listCollectionList
            // 
            this.listCollectionList.FormattingEnabled = true;
            this.listCollectionList.Items.AddRange(new object[] {
            "loading..."});
            this.listCollectionList.Location = new System.Drawing.Point(26, 69);
            this.listCollectionList.Name = "listCollectionList";
            this.listCollectionList.Size = new System.Drawing.Size(209, 264);
            this.listCollectionList.TabIndex = 5;
            this.listCollectionList.SelectedIndexChanged += new System.EventHandler(this.listCollectionList_SelectedIndexChanged);
            // 
            // lbCollectionList
            // 
            this.lbCollectionList.AutoSize = true;
            this.lbCollectionList.Location = new System.Drawing.Point(23, 49);
            this.lbCollectionList.Name = "lbCollectionList";
            this.lbCollectionList.Size = new System.Drawing.Size(61, 13);
            this.lbCollectionList.TabIndex = 6;
            this.lbCollectionList.Text = "Collections:";
            // 
            // lCollectionId
            // 
            this.lCollectionId.AutoSize = true;
            this.lCollectionId.Location = new System.Drawing.Point(351, 21);
            this.lCollectionId.Name = "lCollectionId";
            this.lCollectionId.Size = new System.Drawing.Size(70, 13);
            this.lCollectionId.TabIndex = 8;
            this.lCollectionId.Text = "Collection ID:";
            // 
            // tbCollectionId
            // 
            this.tbCollectionId.Location = new System.Drawing.Point(424, 18);
            this.tbCollectionId.Name = "tbCollectionId";
            this.tbCollectionId.Size = new System.Drawing.Size(203, 20);
            this.tbCollectionId.TabIndex = 7;
            this.tbCollectionId.TextChanged += new System.EventHandler(this.tbCollectionId_TextChanged);
            // 
            // rtbOutput
            // 
            this.rtbOutput.Location = new System.Drawing.Point(351, 204);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(641, 234);
            this.rtbOutput.TabIndex = 9;
            this.rtbOutput.Text = "";
            // 
            // lCollName
            // 
            this.lCollName.AutoSize = true;
            this.lCollName.Location = new System.Drawing.Point(23, 352);
            this.lCollName.Name = "lCollName";
            this.lCollName.Size = new System.Drawing.Size(87, 13);
            this.lCollName.TabIndex = 13;
            this.lCollName.Text = "Collection Name:";
            // 
            // tbCollName
            // 
            this.tbCollName.Location = new System.Drawing.Point(116, 349);
            this.tbCollName.Name = "tbCollName";
            this.tbCollName.Size = new System.Drawing.Size(119, 20);
            this.tbCollName.TabIndex = 12;
            this.tbCollName.TextChanged += new System.EventHandler(this.tbCollName_TextChanged);
            // 
            // btCollectionCreate
            // 
            this.btCollectionCreate.Enabled = false;
            this.btCollectionCreate.Location = new System.Drawing.Point(26, 375);
            this.btCollectionCreate.Name = "btCollectionCreate";
            this.btCollectionCreate.Size = new System.Drawing.Size(209, 23);
            this.btCollectionCreate.TabIndex = 14;
            this.btCollectionCreate.Text = "Create Collection";
            this.btCollectionCreate.UseVisualStyleBackColor = true;
            this.btCollectionCreate.Click += new System.EventHandler(this.btCollectionCreate_Click);
            // 
            // lOutput
            // 
            this.lOutput.AutoSize = true;
            this.lOutput.Location = new System.Drawing.Point(351, 188);
            this.lOutput.Name = "lOutput";
            this.lOutput.Size = new System.Drawing.Size(42, 13);
            this.lOutput.TabIndex = 15;
            this.lOutput.Text = "Output:";
            // 
            // pbAssetUpload
            // 
            this.pbAssetUpload.Location = new System.Drawing.Point(351, 138);
            this.pbAssetUpload.Name = "pbAssetUpload";
            this.pbAssetUpload.Size = new System.Drawing.Size(276, 23);
            this.pbAssetUpload.TabIndex = 16;
            // 
            // btUploadAssetStorage
            // 
            this.btUploadAssetStorage.Enabled = false;
            this.btUploadAssetStorage.Location = new System.Drawing.Point(492, 109);
            this.btUploadAssetStorage.Name = "btUploadAssetStorage";
            this.btUploadAssetStorage.Size = new System.Drawing.Size(135, 23);
            this.btUploadAssetStorage.TabIndex = 17;
            this.btUploadAssetStorage.Text = "Upload Asset Storage";
            this.btUploadAssetStorage.UseVisualStyleBackColor = true;
            this.btUploadAssetStorage.Click += new System.EventHandler(this.btUploadAssetStorage_Click);
            // 
            // lAssetId
            // 
            this.lAssetId.AutoSize = true;
            this.lAssetId.Location = new System.Drawing.Point(687, 24);
            this.lAssetId.Name = "lAssetId";
            this.lAssetId.Size = new System.Drawing.Size(50, 13);
            this.lAssetId.TabIndex = 19;
            this.lAssetId.Text = "Asset ID:";
            // 
            // tbAssetId
            // 
            this.tbAssetId.Location = new System.Drawing.Point(743, 21);
            this.tbAssetId.Name = "tbAssetId";
            this.tbAssetId.Size = new System.Drawing.Size(203, 20);
            this.tbAssetId.TabIndex = 18;
            this.tbAssetId.TextChanged += new System.EventHandler(this.tbAssetId_TextChanged);
            // 
            // lVersionFile
            // 
            this.lVersionFile.AutoSize = true;
            this.lVersionFile.Location = new System.Drawing.Point(771, 114);
            this.lVersionFile.Name = "lVersionFile";
            this.lVersionFile.Size = new System.Drawing.Size(83, 13);
            this.lVersionFile.TabIndex = 23;
            this.lVersionFile.Text = "No file selected.";
            // 
            // btVersionOpenDialog
            // 
            this.btVersionOpenDialog.Location = new System.Drawing.Point(688, 109);
            this.btVersionOpenDialog.Name = "btVersionOpenDialog";
            this.btVersionOpenDialog.Size = new System.Drawing.Size(74, 23);
            this.btVersionOpenDialog.TabIndex = 22;
            this.btVersionOpenDialog.Text = "Select";
            this.btVersionOpenDialog.UseVisualStyleBackColor = true;
            this.btVersionOpenDialog.Click += new System.EventHandler(this.btVersionOpenDialog_Click);
            // 
            // btCreateVersion
            // 
            this.btCreateVersion.Enabled = false;
            this.btCreateVersion.Location = new System.Drawing.Point(688, 138);
            this.btCreateVersion.Name = "btCreateVersion";
            this.btCreateVersion.Size = new System.Drawing.Size(135, 23);
            this.btCreateVersion.TabIndex = 24;
            this.btCreateVersion.Text = "Create version";
            this.btCreateVersion.UseVisualStyleBackColor = true;
            this.btCreateVersion.Click += new System.EventHandler(this.btCreateVersion_Click);
            // 
            // lAssetStatus
            // 
            this.lAssetStatus.AutoSize = true;
            this.lAssetStatus.Location = new System.Drawing.Point(862, 54);
            this.lAssetStatus.Name = "lAssetStatus";
            this.lAssetStatus.Size = new System.Drawing.Size(84, 13);
            this.lAssetStatus.TabIndex = 25;
            this.lAssetStatus.Text = "Status unknown";
            this.lAssetStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btCheckAsset
            // 
            this.btCheckAsset.Enabled = false;
            this.btCheckAsset.Location = new System.Drawing.Point(690, 49);
            this.btCheckAsset.Name = "btCheckAsset";
            this.btCheckAsset.Size = new System.Drawing.Size(135, 23);
            this.btCheckAsset.TabIndex = 26;
            this.btCheckAsset.Text = "Check Asset";
            this.btCheckAsset.UseVisualStyleBackColor = true;
            this.btCheckAsset.Click += new System.EventHandler(this.btCheckAsset_Click);
            // 
            // AgravityUploadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 450);
            this.Controls.Add(this.btCheckAsset);
            this.Controls.Add(this.lAssetStatus);
            this.Controls.Add(this.btCreateVersion);
            this.Controls.Add(this.lVersionFile);
            this.Controls.Add(this.btVersionOpenDialog);
            this.Controls.Add(this.lAssetId);
            this.Controls.Add(this.tbAssetId);
            this.Controls.Add(this.btUploadAssetStorage);
            this.Controls.Add(this.pbAssetUpload);
            this.Controls.Add(this.lOutput);
            this.Controls.Add(this.btCollectionCreate);
            this.Controls.Add(this.lCollName);
            this.Controls.Add(this.tbCollName);
            this.Controls.Add(this.rtbOutput);
            this.Controls.Add(this.lCollectionId);
            this.Controls.Add(this.tbCollectionId);
            this.Controls.Add(this.lbCollectionList);
            this.Controls.Add(this.listCollectionList);
            this.Controls.Add(this.lbFileSelected);
            this.Controls.Add(this.btOpenFile);
            this.Controls.Add(this.lAssetName);
            this.Controls.Add(this.tbAssetName);
            this.Controls.Add(this.btUploadAsset);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AgravityUploadForm";
            this.Text = "AgravityUploadForm";
            this.Load += new System.EventHandler(this.AgravityUploadForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btUploadAsset;
        private System.Windows.Forms.TextBox tbAssetName;
        private System.Windows.Forms.Label lAssetName;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btOpenFile;
        private System.Windows.Forms.Label lbFileSelected;
        private System.Windows.Forms.ListBox listCollectionList;
        private System.Windows.Forms.Label lbCollectionList;
        private System.Windows.Forms.Label lCollectionId;
        private System.Windows.Forms.TextBox tbCollectionId;
        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.Label lCollName;
        private System.Windows.Forms.TextBox tbCollName;
        private System.Windows.Forms.Button btCollectionCreate;
        private System.Windows.Forms.Label lOutput;
        private System.Windows.Forms.ProgressBar pbAssetUpload;
        private System.Windows.Forms.Button btUploadAssetStorage;
        private System.Windows.Forms.Label lAssetId;
        private System.Windows.Forms.TextBox tbAssetId;
        private System.Windows.Forms.Label lVersionFile;
        private System.Windows.Forms.Button btVersionOpenDialog;
        private System.Windows.Forms.Button btCreateVersion;
        private System.Windows.Forms.Label lAssetStatus;
        private System.Windows.Forms.Button btCheckAsset;
    }
}

