namespace CSharp_ChromaStreamApp
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this._mBtnGetShortcode = new System.Windows.Forms.Button();
            this._mTxtShortcode = new System.Windows.Forms.Label();
            this._mBtnCopy = new System.Windows.Forms.Button();
            this._mLink = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this._mTxtStreamId = new System.Windows.Forms.TextBox();
            this._mTxtStreamKey = new System.Windows.Forms.TextBox();
            this._mChkBroadcast = new System.Windows.Forms.CheckBox();
            this._mPanelBroadcast = new System.Windows.Forms.Panel();
            this._mTxtStatus = new System.Windows.Forms.Label();
            this._mPanelNotSupported = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this._mLinkSynapse = new System.Windows.Forms.LinkLabel();
            this._mTimerForm = new System.Windows.Forms.Timer(this.components);
            this._mPanelBroadcast.SuspendLayout();
            this._mPanelNotSupported.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Authorize Stream Source";
            // 
            // _mBtnGetShortcode
            // 
            this._mBtnGetShortcode.Enabled = false;
            this._mBtnGetShortcode.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._mBtnGetShortcode.Location = new System.Drawing.Point(15, 38);
            this._mBtnGetShortcode.Name = "_mBtnGetShortcode";
            this._mBtnGetShortcode.Size = new System.Drawing.Size(136, 53);
            this._mBtnGetShortcode.TabIndex = 1;
            this._mBtnGetShortcode.Text = "Get Shortcode";
            this._mBtnGetShortcode.UseVisualStyleBackColor = true;
            this._mBtnGetShortcode.Click += new System.EventHandler(this._mBtnGetStreamCode_Click);
            // 
            // _mTxtShortcode
            // 
            this._mTxtShortcode.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this._mTxtShortcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._mTxtShortcode.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._mTxtShortcode.Location = new System.Drawing.Point(157, 38);
            this._mTxtShortcode.Name = "_mTxtShortcode";
            this._mTxtShortcode.Size = new System.Drawing.Size(116, 53);
            this._mTxtShortcode.TabIndex = 2;
            this._mTxtShortcode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _mBtnCopy
            // 
            this._mBtnCopy.Enabled = false;
            this._mBtnCopy.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._mBtnCopy.Location = new System.Drawing.Point(279, 38);
            this._mBtnCopy.Name = "_mBtnCopy";
            this._mBtnCopy.Size = new System.Drawing.Size(70, 53);
            this._mBtnCopy.TabIndex = 3;
            this._mBtnCopy.Text = "Copy";
            this._mBtnCopy.UseVisualStyleBackColor = true;
            this._mBtnCopy.Click += new System.EventHandler(this._mBtnCopy_Click);
            // 
            // _mLink
            // 
            this._mLink.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._mLink.Location = new System.Drawing.Point(355, 38);
            this._mLink.Name = "_mLink";
            this._mLink.Size = new System.Drawing.Size(229, 53);
            this._mLink.TabIndex = 4;
            this._mLink.TabStop = true;
            this._mLink.Text = "Open Razer Streaming Portal";
            this._mLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._mLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this._mLink_LinkClicked);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Stream Id:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Stream Key:";
            // 
            // _mTxtStreamId
            // 
            this._mTxtStreamId.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._mTxtStreamId.Location = new System.Drawing.Point(133, 106);
            this._mTxtStreamId.MaxLength = 48;
            this._mTxtStreamId.Name = "_mTxtStreamId";
            this._mTxtStreamId.Size = new System.Drawing.Size(292, 23);
            this._mTxtStreamId.TabIndex = 7;
            this._mTxtStreamId.TextChanged += new System.EventHandler(this._mTxtStreamId_TextChanged);
            // 
            // _mTxtStreamKey
            // 
            this._mTxtStreamKey.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._mTxtStreamKey.Location = new System.Drawing.Point(133, 139);
            this._mTxtStreamKey.MaxLength = 48;
            this._mTxtStreamKey.Name = "_mTxtStreamKey";
            this._mTxtStreamKey.PasswordChar = '*';
            this._mTxtStreamKey.Size = new System.Drawing.Size(292, 23);
            this._mTxtStreamKey.TabIndex = 8;
            this._mTxtStreamKey.TextChanged += new System.EventHandler(this._mTxtStreamKey_TextChanged);
            // 
            // _mChkBroadcast
            // 
            this._mChkBroadcast.AutoSize = true;
            this._mChkBroadcast.Enabled = false;
            this._mChkBroadcast.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._mChkBroadcast.Location = new System.Drawing.Point(15, 185);
            this._mChkBroadcast.Name = "_mChkBroadcast";
            this._mChkBroadcast.Size = new System.Drawing.Size(179, 23);
            this._mChkBroadcast.TabIndex = 9;
            this._mChkBroadcast.Text = "Broadcast Chroma RGB";
            this._mChkBroadcast.UseVisualStyleBackColor = true;
            this._mChkBroadcast.CheckedChanged += new System.EventHandler(this._mChkBroadcast_CheckedChanged);
            // 
            // _mPanelBroadcast
            // 
            this._mPanelBroadcast.Controls.Add(this._mTxtStatus);
            this._mPanelBroadcast.Controls.Add(this._mBtnGetShortcode);
            this._mPanelBroadcast.Controls.Add(this._mChkBroadcast);
            this._mPanelBroadcast.Controls.Add(this.label1);
            this._mPanelBroadcast.Controls.Add(this._mTxtStreamKey);
            this._mPanelBroadcast.Controls.Add(this._mTxtShortcode);
            this._mPanelBroadcast.Controls.Add(this._mTxtStreamId);
            this._mPanelBroadcast.Controls.Add(this._mBtnCopy);
            this._mPanelBroadcast.Controls.Add(this.label4);
            this._mPanelBroadcast.Controls.Add(this._mLink);
            this._mPanelBroadcast.Controls.Add(this.label3);
            this._mPanelBroadcast.Location = new System.Drawing.Point(12, 12);
            this._mPanelBroadcast.Name = "_mPanelBroadcast";
            this._mPanelBroadcast.Size = new System.Drawing.Size(641, 242);
            this._mPanelBroadcast.TabIndex = 10;
            // 
            // _mTxtStatus
            // 
            this._mTxtStatus.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._mTxtStatus.Location = new System.Drawing.Point(275, 186);
            this._mTxtStatus.Name = "_mTxtStatus";
            this._mTxtStatus.Size = new System.Drawing.Size(360, 47);
            this._mTxtStatus.TabIndex = 10;
            this._mTxtStatus.Text = "Status:";
            // 
            // _mPanelNotSupported
            // 
            this._mPanelNotSupported.Controls.Add(this.label2);
            this._mPanelNotSupported.Controls.Add(this._mLinkSynapse);
            this._mPanelNotSupported.Location = new System.Drawing.Point(12, 12);
            this._mPanelNotSupported.Name = "_mPanelNotSupported";
            this._mPanelNotSupported.Size = new System.Drawing.Size(638, 242);
            this._mPanelNotSupported.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(615, 80);
            this.label2.TabIndex = 6;
            this.label2.Text = "Streaming Chroma RGB is not supported. Be sure to update to the latest version of" +
    " Synapse and install the Chroma Connect module.";
            // 
            // _mLinkSynapse
            // 
            this._mLinkSynapse.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._mLinkSynapse.Location = new System.Drawing.Point(212, 113);
            this._mLinkSynapse.Name = "_mLinkSynapse";
            this._mLinkSynapse.Size = new System.Drawing.Size(229, 53);
            this._mLinkSynapse.TabIndex = 5;
            this._mLinkSynapse.TabStop = true;
            this._mLinkSynapse.Text = "Get Razer Synapse";
            this._mLinkSynapse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._mLinkSynapse.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this._mLinkSynapse_LinkClicked);
            // 
            // _mTimerForm
            // 
            this._mTimerForm.Interval = 1000;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 264);
            this.Controls.Add(this._mPanelBroadcast);
            this.Controls.Add(this._mPanelNotSupported);
            this.Name = "Form1";
            this.Text = "Chroma Stream App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this._mPanelBroadcast.ResumeLayout(false);
            this._mPanelBroadcast.PerformLayout();
            this._mPanelNotSupported.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button _mBtnGetShortcode;
        private System.Windows.Forms.Label _mTxtShortcode;
        private System.Windows.Forms.Button _mBtnCopy;
        private System.Windows.Forms.LinkLabel _mLink;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox _mTxtStreamId;
        private System.Windows.Forms.TextBox _mTxtStreamKey;
        private System.Windows.Forms.CheckBox _mChkBroadcast;
        private System.Windows.Forms.Panel _mPanelBroadcast;
        private System.Windows.Forms.Panel _mPanelNotSupported;
        private System.Windows.Forms.LinkLabel _mLinkSynapse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer _mTimerForm;
        private System.Windows.Forms.Label _mTxtStatus;
    }
}

