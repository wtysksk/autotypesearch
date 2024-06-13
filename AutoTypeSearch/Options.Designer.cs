using KeePass.UI;

namespace AutoTypeSearch
{
	partial class Options
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.Windows.Forms.GroupBox searchOptionsGroup;
            System.Windows.Forms.GroupBox searchInGroup;
            System.Windows.Forms.Label defaultActionLabel;
            System.Windows.Forms.Label alternativeActionLabel;
            this.mResolveReferences = new System.Windows.Forms.CheckBox();
            this.mExcludeExpired = new System.Windows.Forms.CheckBox();
            this.mCaseSensitive = new System.Windows.Forms.CheckBox();
            this.mSearchInTags = new System.Windows.Forms.CheckBox();
            this.mSearchInOtherFields = new System.Windows.Forms.CheckBox();
            this.mSearchInNotes = new System.Windows.Forms.CheckBox();
            this.mSearchInUrl = new System.Windows.Forms.CheckBox();
            this.mSearchInUserName = new System.Windows.Forms.CheckBox();
            this.mSearchInTitle = new System.Windows.Forms.CheckBox();
            this.mCustomField = new System.Windows.Forms.TextBox();
            this.labelCustomField = new System.Windows.Forms.Label();
            this.mDefaultAction = new System.Windows.Forms.ComboBox();
            this.mAlternativeAction = new System.Windows.Forms.ComboBox();
            this.mThirdAction = new System.Windows.Forms.ComboBox();
            this.labelThirdAction = new System.Windows.Forms.Label();
            this.mShowHotKeyControl = new KeePass.UI.HotKeyControlEx();
            this.mShowSearchGroup = new System.Windows.Forms.GroupBox();
            this.mKeepWindowOpen = new System.Windows.Forms.CheckBox();
            this.mShowOnHotKey = new System.Windows.Forms.CheckBox();
            this.mShowOnIPC = new System.Windows.Forms.CheckBox();
            this.mShowOnFailedSearch = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            searchOptionsGroup = new System.Windows.Forms.GroupBox();
            searchInGroup = new System.Windows.Forms.GroupBox();
            defaultActionLabel = new System.Windows.Forms.Label();
            alternativeActionLabel = new System.Windows.Forms.Label();
            searchOptionsGroup.SuspendLayout();
            searchInGroup.SuspendLayout();
            this.mShowSearchGroup.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchOptionsGroup
            // 
            searchOptionsGroup.Controls.Add(this.mResolveReferences);
            searchOptionsGroup.Controls.Add(this.mExcludeExpired);
            searchOptionsGroup.Controls.Add(this.mCaseSensitive);
            searchOptionsGroup.Location = new System.Drawing.Point(0, 251);
            searchOptionsGroup.Margin = new System.Windows.Forms.Padding(4);
            searchOptionsGroup.Name = "searchOptionsGroup";
            searchOptionsGroup.Padding = new System.Windows.Forms.Padding(4);
            searchOptionsGroup.Size = new System.Drawing.Size(810, 142);
            searchOptionsGroup.TabIndex = 2;
            searchOptionsGroup.TabStop = false;
            searchOptionsGroup.Text = "Search options";
            // 
            // mResolveReferences
            // 
            this.mResolveReferences.AutoSize = true;
            this.mResolveReferences.Location = new System.Drawing.Point(297, 29);
            this.mResolveReferences.Margin = new System.Windows.Forms.Padding(4);
            this.mResolveReferences.Name = "mResolveReferences";
            this.mResolveReferences.Size = new System.Drawing.Size(313, 22);
            this.mResolveReferences.TabIndex = 2;
            this.mResolveReferences.Text = "Resolve fiel&d references (slow)";
            this.mResolveReferences.UseVisualStyleBackColor = true;
            // 
            // mExcludeExpired
            // 
            this.mExcludeExpired.AutoSize = true;
            this.mExcludeExpired.Location = new System.Drawing.Point(14, 67);
            this.mExcludeExpired.Margin = new System.Windows.Forms.Padding(4);
            this.mExcludeExpired.Name = "mExcludeExpired";
            this.mExcludeExpired.Size = new System.Drawing.Size(241, 22);
            this.mExcludeExpired.TabIndex = 1;
            this.mExcludeExpired.Text = "Exclude &expired entries";
            this.mExcludeExpired.UseVisualStyleBackColor = true;
            // 
            // mCaseSensitive
            // 
            this.mCaseSensitive.AutoSize = true;
            this.mCaseSensitive.Location = new System.Drawing.Point(15, 28);
            this.mCaseSensitive.Margin = new System.Windows.Forms.Padding(4);
            this.mCaseSensitive.Name = "mCaseSensitive";
            this.mCaseSensitive.Size = new System.Drawing.Size(160, 22);
            this.mCaseSensitive.TabIndex = 0;
            this.mCaseSensitive.Text = "Case-sensiti&ve";
            this.mCaseSensitive.UseVisualStyleBackColor = true;
            // 
            // searchInGroup
            // 
            searchInGroup.Controls.Add(this.mSearchInTags);
            searchInGroup.Controls.Add(this.mSearchInOtherFields);
            searchInGroup.Controls.Add(this.mSearchInNotes);
            searchInGroup.Controls.Add(this.mSearchInUrl);
            searchInGroup.Controls.Add(this.mSearchInUserName);
            searchInGroup.Controls.Add(this.mSearchInTitle);
            searchInGroup.Location = new System.Drawing.Point(0, 178);
            searchInGroup.Margin = new System.Windows.Forms.Padding(4);
            searchInGroup.Name = "searchInGroup";
            searchInGroup.Padding = new System.Windows.Forms.Padding(4);
            searchInGroup.Size = new System.Drawing.Size(810, 65);
            searchInGroup.TabIndex = 1;
            searchInGroup.TabStop = false;
            searchInGroup.Text = "Search in";
            // 
            // mSearchInTags
            // 
            this.mSearchInTags.AutoSize = true;
            this.mSearchInTags.Location = new System.Drawing.Point(387, 26);
            this.mSearchInTags.Margin = new System.Windows.Forms.Padding(4);
            this.mSearchInTags.Name = "mSearchInTags";
            this.mSearchInTags.Size = new System.Drawing.Size(70, 22);
            this.mSearchInTags.TabIndex = 4;
            this.mSearchInTags.Text = "Ta&gs";
            this.mSearchInTags.UseVisualStyleBackColor = true;
            // 
            // mSearchInOtherFields
            // 
            this.mSearchInOtherFields.AutoSize = true;
            this.mSearchInOtherFields.Location = new System.Drawing.Point(471, 26);
            this.mSearchInOtherFields.Margin = new System.Windows.Forms.Padding(4);
            this.mSearchInOtherFields.Name = "mSearchInOtherFields";
            this.mSearchInOtherFields.Size = new System.Drawing.Size(250, 22);
            this.mSearchInOtherFields.TabIndex = 5;
            this.mSearchInOtherFields.Text = "&Other unprotected fields";
            this.mSearchInOtherFields.UseVisualStyleBackColor = true;
            // 
            // mSearchInNotes
            // 
            this.mSearchInNotes.AutoSize = true;
            this.mSearchInNotes.Location = new System.Drawing.Point(297, 26);
            this.mSearchInNotes.Margin = new System.Windows.Forms.Padding(4);
            this.mSearchInNotes.Name = "mSearchInNotes";
            this.mSearchInNotes.Size = new System.Drawing.Size(79, 22);
            this.mSearchInNotes.TabIndex = 3;
            this.mSearchInNotes.Text = "Note&s";
            this.mSearchInNotes.UseVisualStyleBackColor = true;
            // 
            // mSearchInUrl
            // 
            this.mSearchInUrl.AutoSize = true;
            this.mSearchInUrl.Location = new System.Drawing.Point(216, 26);
            this.mSearchInUrl.Margin = new System.Windows.Forms.Padding(4);
            this.mSearchInUrl.Name = "mSearchInUrl";
            this.mSearchInUrl.Size = new System.Drawing.Size(61, 22);
            this.mSearchInUrl.TabIndex = 2;
            this.mSearchInUrl.Text = "&URL";
            this.mSearchInUrl.UseVisualStyleBackColor = true;
            // 
            // mSearchInUserName
            // 
            this.mSearchInUserName.AutoSize = true;
            this.mSearchInUserName.Location = new System.Drawing.Point(92, 26);
            this.mSearchInUserName.Margin = new System.Windows.Forms.Padding(4);
            this.mSearchInUserName.Name = "mSearchInUserName";
            this.mSearchInUserName.Size = new System.Drawing.Size(115, 22);
            this.mSearchInUserName.TabIndex = 1;
            this.mSearchInUserName.Text = "User &name";
            this.mSearchInUserName.UseVisualStyleBackColor = true;
            // 
            // mSearchInTitle
            // 
            this.mSearchInTitle.AutoSize = true;
            this.mSearchInTitle.Location = new System.Drawing.Point(14, 26);
            this.mSearchInTitle.Margin = new System.Windows.Forms.Padding(4);
            this.mSearchInTitle.Name = "mSearchInTitle";
            this.mSearchInTitle.Size = new System.Drawing.Size(79, 22);
            this.mSearchInTitle.TabIndex = 0;
            this.mSearchInTitle.Text = "&Title";
            this.mSearchInTitle.UseVisualStyleBackColor = true;
            // 
            // mCustomField
            // 
            this.mCustomField.Location = new System.Drawing.Point(430, 125);
            this.mCustomField.Name = "mCustomField";
            this.mCustomField.Size = new System.Drawing.Size(356, 28);
            this.mCustomField.TabIndex = 7;
            // 
            // defaultActionLabel
            // 
            defaultActionLabel.AutoSize = true;
            defaultActionLabel.Location = new System.Drawing.Point(8, 29);
            defaultActionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            defaultActionLabel.Name = "defaultActionLabel";
            defaultActionLabel.Size = new System.Drawing.Size(215, 18);
            defaultActionLabel.TabIndex = 0;
            defaultActionLabel.Text = "De&fault action (Enter):";
            // 
            // alternativeActionLabel
            // 
            alternativeActionLabel.AutoSize = true;
            alternativeActionLabel.Location = new System.Drawing.Point(424, 29);
            alternativeActionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            alternativeActionLabel.Name = "alternativeActionLabel";
            alternativeActionLabel.Size = new System.Drawing.Size(323, 18);
            alternativeActionLabel.TabIndex = 2;
            alternativeActionLabel.Text = "A&lternative action (Shift + Enter):";
            // 
            // labelCustomField
            // 
            this.labelCustomField.AutoSize = true;
            this.labelCustomField.Location = new System.Drawing.Point(427, 100);
            this.labelCustomField.Name = "labelCustomField";
            this.labelCustomField.Size = new System.Drawing.Size(116, 18);
            this.labelCustomField.TabIndex = 6;
            this.labelCustomField.Text = "Custom Field";
            // 
            // mDefaultAction
            // 
            this.mDefaultAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mDefaultAction.Location = new System.Drawing.Point(12, 52);
            this.mDefaultAction.Margin = new System.Windows.Forms.Padding(4);
            this.mDefaultAction.Name = "mDefaultAction";
            this.mDefaultAction.Size = new System.Drawing.Size(358, 26);
            this.mDefaultAction.TabIndex = 1;
            // 
            // mAlternativeAction
            // 
            this.mAlternativeAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mAlternativeAction.Location = new System.Drawing.Point(428, 52);
            this.mAlternativeAction.Margin = new System.Windows.Forms.Padding(4);
            this.mAlternativeAction.Name = "mAlternativeAction";
            this.mAlternativeAction.Size = new System.Drawing.Size(358, 26);
            this.mAlternativeAction.TabIndex = 3;
            // 
            // mThirdAction
            // 
            this.mThirdAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mThirdAction.Location = new System.Drawing.Point(12, 128);
            this.mThirdAction.Margin = new System.Windows.Forms.Padding(4);
            this.mThirdAction.Name = "mThirdAction";
            this.mThirdAction.Size = new System.Drawing.Size(358, 26);
            this.mThirdAction.TabIndex = 5;
            // 
            // labelThirdAction
            // 
            this.labelThirdAction.AutoSize = true;
            this.labelThirdAction.Location = new System.Drawing.Point(9, 100);
            this.labelThirdAction.Name = "labelThirdAction";
            this.labelThirdAction.Size = new System.Drawing.Size(224, 18);
            this.labelThirdAction.TabIndex = 4;
            this.labelThirdAction.Text = "Third Action(Ctrl+Enter)";
            // 
            // mShowHotKeyControl
            // 
            this.mShowHotKeyControl.Location = new System.Drawing.Point(434, 55);
            this.mShowHotKeyControl.Margin = new System.Windows.Forms.Padding(4);
            this.mShowHotKeyControl.Name = "mShowHotKeyControl";
            this.mShowHotKeyControl.Size = new System.Drawing.Size(287, 28);
            this.mShowHotKeyControl.TabIndex = 2;
            // 
            // mShowSearchGroup
            // 
            this.mShowSearchGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mShowSearchGroup.Controls.Add(this.mKeepWindowOpen);
            this.mShowSearchGroup.Controls.Add(this.mShowOnHotKey);
            this.mShowSearchGroup.Controls.Add(this.mShowHotKeyControl);
            this.mShowSearchGroup.Controls.Add(this.mShowOnIPC);
            this.mShowSearchGroup.Controls.Add(this.mShowOnFailedSearch);
            this.mShowSearchGroup.Location = new System.Drawing.Point(0, 14);
            this.mShowSearchGroup.Margin = new System.Windows.Forms.Padding(4);
            this.mShowSearchGroup.Name = "mShowSearchGroup";
            this.mShowSearchGroup.Padding = new System.Windows.Forms.Padding(4);
            this.mShowSearchGroup.Size = new System.Drawing.Size(810, 156);
            this.mShowSearchGroup.TabIndex = 0;
            this.mShowSearchGroup.TabStop = false;
            this.mShowSearchGroup.Text = "Show search window";
            // 
            // mKeepWindowOpen
            // 
            this.mKeepWindowOpen.AutoSize = true;
            this.mKeepWindowOpen.Location = new System.Drawing.Point(15, 123);
            this.mKeepWindowOpen.Margin = new System.Windows.Forms.Padding(4);
            this.mKeepWindowOpen.Name = "mKeepWindowOpen";
            this.mKeepWindowOpen.Size = new System.Drawing.Size(529, 22);
            this.mKeepWindowOpen.TabIndex = 4;
            this.mKeepWindowOpen.Text = "&Keep search window open until dismissed with Escape key";
            this.mKeepWindowOpen.UseVisualStyleBackColor = true;
            // 
            // mShowOnHotKey
            // 
            this.mShowOnHotKey.AutoSize = true;
            this.mShowOnHotKey.Location = new System.Drawing.Point(15, 61);
            this.mShowOnHotKey.Margin = new System.Windows.Forms.Padding(4);
            this.mShowOnHotKey.Name = "mShowOnHotKey";
            this.mShowOnHotKey.Size = new System.Drawing.Size(403, 22);
            this.mShowOnHotKey.TabIndex = 1;
            this.mShowOnHotKey.Text = "Show when system-wide &hot key is pressed:";
            this.mShowOnHotKey.UseVisualStyleBackColor = true;
            this.mShowOnHotKey.CheckedChanged += new System.EventHandler(this.mShowOnHotKey_CheckedChanged);
            // 
            // mShowOnIPC
            // 
            this.mShowOnIPC.AutoSize = true;
            this.mShowOnIPC.Location = new System.Drawing.Point(15, 91);
            this.mShowOnIPC.Margin = new System.Windows.Forms.Padding(4);
            this.mShowOnIPC.Name = "mShowOnIPC";
            this.mShowOnIPC.Size = new System.Drawing.Size(664, 22);
            this.mShowOnIPC.TabIndex = 3;
            this.mShowOnIPC.Text = "Show when \"/e1:AutoTypeSearch\" is passed as a &parameter to KeePass.exe";
            this.mShowOnIPC.UseVisualStyleBackColor = true;
            // 
            // mShowOnFailedSearch
            // 
            this.mShowOnFailedSearch.AutoSize = true;
            this.mShowOnFailedSearch.Location = new System.Drawing.Point(15, 29);
            this.mShowOnFailedSearch.Margin = new System.Windows.Forms.Padding(4);
            this.mShowOnFailedSearch.Name = "mShowOnFailedSearch";
            this.mShowOnFailedSearch.Size = new System.Drawing.Size(511, 22);
            this.mShowOnFailedSearch.TabIndex = 0;
            this.mShowOnFailedSearch.Text = "Show &automatically if global auto-type finds no match";
            this.mShowOnFailedSearch.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(810, 432);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(searchOptionsGroup);
            this.tabPage1.Controls.Add(this.mShowSearchGroup);
            this.tabPage1.Controls.Add(searchInGroup);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(802, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Options";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.mCustomField);
            this.tabPage2.Controls.Add(defaultActionLabel);
            this.tabPage2.Controls.Add(this.labelThirdAction);
            this.tabPage2.Controls.Add(alternativeActionLabel);
            this.tabPage2.Controls.Add(this.mThirdAction);
            this.tabPage2.Controls.Add(this.labelCustomField);
            this.tabPage2.Controls.Add(this.mAlternativeAction);
            this.tabPage2.Controls.Add(this.mDefaultAction);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(802, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Hotkeys";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Options";
            this.Size = new System.Drawing.Size(829, 468);
            searchOptionsGroup.ResumeLayout(false);
            searchOptionsGroup.PerformLayout();
            searchInGroup.ResumeLayout(false);
            searchInGroup.PerformLayout();
            this.mShowSearchGroup.ResumeLayout(false);
            this.mShowSearchGroup.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private KeePass.UI.HotKeyControlEx mShowHotKeyControl;
		private System.Windows.Forms.CheckBox mShowOnHotKey;
		private System.Windows.Forms.CheckBox mShowOnIPC;
		private System.Windows.Forms.CheckBox mShowOnFailedSearch;
		private System.Windows.Forms.CheckBox mCaseSensitive;
		private System.Windows.Forms.CheckBox mSearchInTags;
		private System.Windows.Forms.CheckBox mSearchInOtherFields;
		private System.Windows.Forms.CheckBox mSearchInNotes;
		private System.Windows.Forms.CheckBox mSearchInUrl;
		private System.Windows.Forms.CheckBox mSearchInUserName;
		private System.Windows.Forms.CheckBox mSearchInTitle;
		private System.Windows.Forms.CheckBox mResolveReferences;
		private System.Windows.Forms.CheckBox mExcludeExpired;
		private System.Windows.Forms.ComboBox mAlternativeAction;
		private System.Windows.Forms.ComboBox mDefaultAction;
		private System.Windows.Forms.GroupBox mShowSearchGroup;
        private System.Windows.Forms.CheckBox mKeepWindowOpen;
        private System.Windows.Forms.Label labelCustomField;
        private System.Windows.Forms.ComboBox mThirdAction;
        private System.Windows.Forms.Label labelThirdAction;
        private System.Windows.Forms.TextBox mCustomField;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}
