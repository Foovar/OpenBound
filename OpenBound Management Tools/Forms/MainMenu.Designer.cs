﻿
namespace OpenBound_Management_Tools.Forms
{
    partial class MainMenu
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
            this.dockerInstallFetchServerContainerButton = new System.Windows.Forms.Button();
            this.createGameUpdatePatch = new System.Windows.Forms.Button();
            this.uploadGameUpdatePatchesToAllContainers = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dockerInstallFetchServerContainerButton
            // 
            this.dockerInstallFetchServerContainerButton.Location = new System.Drawing.Point(6, 22);
            this.dockerInstallFetchServerContainerButton.Name = "dockerInstallFetchServerContainerButton";
            this.dockerInstallFetchServerContainerButton.Size = new System.Drawing.Size(238, 38);
            this.dockerInstallFetchServerContainerButton.TabIndex = 0;
            this.dockerInstallFetchServerContainerButton.Text = "Install Fetch Server Containers";
            this.dockerInstallFetchServerContainerButton.UseVisualStyleBackColor = true;
            this.dockerInstallFetchServerContainerButton.Click += new System.EventHandler(this.DockerInstallFetchServerContainersButton_Click);
            // 
            // createGameUpdatePatch
            // 
            this.createGameUpdatePatch.Location = new System.Drawing.Point(215, 362);
            this.createGameUpdatePatch.Name = "createGameUpdatePatch";
            this.createGameUpdatePatch.Size = new System.Drawing.Size(161, 26);
            this.createGameUpdatePatch.TabIndex = 1;
            this.createGameUpdatePatch.Text = "Create Game Update Patch";
            this.createGameUpdatePatch.UseVisualStyleBackColor = true;
            // 
            // uploadGameUpdatePatchesToAllContainers
            // 
            this.uploadGameUpdatePatchesToAllContainers.Location = new System.Drawing.Point(6, 22);
            this.uploadGameUpdatePatchesToAllContainers.Name = "uploadGameUpdatePatchesToAllContainers";
            this.uploadGameUpdatePatchesToAllContainers.Size = new System.Drawing.Size(238, 38);
            this.uploadGameUpdatePatchesToAllContainers.TabIndex = 2;
            this.uploadGameUpdatePatchesToAllContainers.Text = "Upload All Existing Game Update Patches To All Containers";
            this.uploadGameUpdatePatchesToAllContainers.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "Edit And Update All PatchHistory.json On Fetch Server Containers";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.uploadGameUpdatePatchesToAllContainers);
            this.groupBox1.Location = new System.Drawing.Point(268, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 250);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fetch Server Container Management";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dockerInstallFetchServerContainerButton);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 250);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Docker Server Installation";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 493);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.createGameUpdatePatch);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button dockerInstallFetchServerContainerButton;
        private System.Windows.Forms.Button createGameUpdatePatch;
        private System.Windows.Forms.Button uploadGameUpdatePatchesToAllContainers;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}