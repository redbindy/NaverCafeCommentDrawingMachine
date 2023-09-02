using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace DrawMachine
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
            saveData();

            if (mDriver != null)
            {
                mDriver.Quit();
                mDriver.Dispose();
            }

            mDriverService.Dispose();

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LinkButton = new System.Windows.Forms.Button();
            this.LinkBox = new System.Windows.Forms.TextBox();
            this.DrawButton = new System.Windows.Forms.Button();
            this.Users = new System.Windows.Forms.ListView();
            this.UserName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UserComment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SelectedUserList = new System.Windows.Forms.ListView();
            this.SelectedName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SelectedComment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Count = new System.Windows.Forms.TextBox();
            this.UrlBox = new System.Windows.Forms.GroupBox();
            this.UserList = new System.Windows.Forms.GroupBox();
            this.SelectingCount = new System.Windows.Forms.GroupBox();
            this.SelectedUserCurr = new System.Windows.Forms.GroupBox();
            this.MakePost = new System.Windows.Forms.Button();
            this.SelectedUserAll = new System.Windows.Forms.GroupBox();
            this.AllUserList = new System.Windows.Forms.ListView();
            this.NickName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AComment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OTP = new System.Windows.Forms.GroupBox();
            this.OTPButton = new System.Windows.Forms.Button();
            this.OTPBox = new System.Windows.Forms.TextBox();
            this.PeopleCount = new System.Windows.Forms.GroupBox();
            this.PeopleCounter = new System.Windows.Forms.Label();
            this.ProgressBar = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.ManualSave = new System.Windows.Forms.Button();
            this.DelayShowing = new System.Windows.Forms.CheckBox();
            this.DelayShowingToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.UrlBox.SuspendLayout();
            this.UserList.SuspendLayout();
            this.SelectingCount.SuspendLayout();
            this.SelectedUserCurr.SuspendLayout();
            this.SelectedUserAll.SuspendLayout();
            this.OTP.SuspendLayout();
            this.PeopleCount.SuspendLayout();
            this.ProgressBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // LinkButton
            // 
            resources.ApplyResources(this.LinkButton, "LinkButton");
            this.LinkButton.Name = "LinkButton";
            this.LinkButton.UseVisualStyleBackColor = true;
            this.LinkButton.Click += new System.EventHandler(this.LinkButton_Click);
            // 
            // LinkBox
            // 
            resources.ApplyResources(this.LinkBox, "LinkBox");
            this.LinkBox.Name = "LinkBox";
            // 
            // DrawButton
            // 
            resources.ApplyResources(this.DrawButton, "DrawButton");
            this.DrawButton.Name = "DrawButton";
            this.DrawButton.UseVisualStyleBackColor = true;
            this.DrawButton.Click += new System.EventHandler(this.DrawButton_Click);
            // 
            // Users
            // 
            this.Users.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.UserName,
            this.UserComment});
            resources.ApplyResources(this.Users, "Users");
            this.Users.HideSelection = false;
            this.Users.Name = "Users";
            this.Users.UseCompatibleStateImageBehavior = false;
            this.Users.View = System.Windows.Forms.View.Details;
            // 
            // UserName
            // 
            resources.ApplyResources(this.UserName, "UserName");
            // 
            // UserComment
            // 
            resources.ApplyResources(this.UserComment, "UserComment");
            // 
            // SelectedUserList
            // 
            this.SelectedUserList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SelectedName,
            this.SelectedComment});
            resources.ApplyResources(this.SelectedUserList, "SelectedUserList");
            this.SelectedUserList.HideSelection = false;
            this.SelectedUserList.Name = "SelectedUserList";
            this.SelectedUserList.UseCompatibleStateImageBehavior = false;
            this.SelectedUserList.View = System.Windows.Forms.View.Details;
            // 
            // SelectedName
            // 
            resources.ApplyResources(this.SelectedName, "SelectedName");
            // 
            // SelectedComment
            // 
            resources.ApplyResources(this.SelectedComment, "SelectedComment");
            // 
            // Count
            // 
            resources.ApplyResources(this.Count, "Count");
            this.Count.Name = "Count";
            this.Count.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Count_KeyPress);
            // 
            // UrlBox
            // 
            resources.ApplyResources(this.UrlBox, "UrlBox");
            this.UrlBox.Controls.Add(this.LinkBox);
            this.UrlBox.Controls.Add(this.LinkButton);
            this.UrlBox.Name = "UrlBox";
            this.UrlBox.TabStop = false;
            // 
            // UserList
            // 
            resources.ApplyResources(this.UserList, "UserList");
            this.UserList.Controls.Add(this.Users);
            this.UserList.Name = "UserList";
            this.UserList.TabStop = false;
            // 
            // SelectingCount
            // 
            this.SelectingCount.Controls.Add(this.Count);
            this.SelectingCount.Controls.Add(this.DrawButton);
            resources.ApplyResources(this.SelectingCount, "SelectingCount");
            this.SelectingCount.Name = "SelectingCount";
            this.SelectingCount.TabStop = false;
            // 
            // SelectedUserCurr
            // 
            resources.ApplyResources(this.SelectedUserCurr, "SelectedUserCurr");
            this.SelectedUserCurr.Controls.Add(this.SelectedUserList);
            this.SelectedUserCurr.Name = "SelectedUserCurr";
            this.SelectedUserCurr.TabStop = false;
            // 
            // MakePost
            // 
            resources.ApplyResources(this.MakePost, "MakePost");
            this.MakePost.Name = "MakePost";
            this.MakePost.UseVisualStyleBackColor = true;
            this.MakePost.Click += new System.EventHandler(this.MakePost_Click);
            // 
            // SelectedUserAll
            // 
            this.SelectedUserAll.Controls.Add(this.AllUserList);
            resources.ApplyResources(this.SelectedUserAll, "SelectedUserAll");
            this.SelectedUserAll.Name = "SelectedUserAll";
            this.SelectedUserAll.TabStop = false;
            // 
            // AllUserList
            // 
            this.AllUserList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NickName,
            this.AComment,
            this.Prize});
            resources.ApplyResources(this.AllUserList, "AllUserList");
            this.AllUserList.HideSelection = false;
            this.AllUserList.Name = "AllUserList";
            this.AllUserList.UseCompatibleStateImageBehavior = false;
            this.AllUserList.View = System.Windows.Forms.View.Details;
            // 
            // NickName
            // 
            resources.ApplyResources(this.NickName, "NickName");
            // 
            // AComment
            // 
            resources.ApplyResources(this.AComment, "AComment");
            // 
            // Prize
            // 
            resources.ApplyResources(this.Prize, "Prize");
            // 
            // OTP
            // 
            resources.ApplyResources(this.OTP, "OTP");
            this.OTP.Controls.Add(this.OTPButton);
            this.OTP.Controls.Add(this.OTPBox);
            this.OTP.Name = "OTP";
            this.OTP.TabStop = false;
            // 
            // OTPButton
            // 
            resources.ApplyResources(this.OTPButton, "OTPButton");
            this.OTPButton.Name = "OTPButton";
            this.OTPButton.UseVisualStyleBackColor = true;
            this.OTPButton.Click += new System.EventHandler(this.OTPButton_Click);
            // 
            // OTPBox
            // 
            resources.ApplyResources(this.OTPBox, "OTPBox");
            this.OTPBox.Name = "OTPBox";
            this.OTPBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Count_KeyPress);
            // 
            // PeopleCount
            // 
            this.PeopleCount.Controls.Add(this.PeopleCounter);
            resources.ApplyResources(this.PeopleCount, "PeopleCount");
            this.PeopleCount.Name = "PeopleCount";
            this.PeopleCount.TabStop = false;
            // 
            // PeopleCounter
            // 
            resources.ApplyResources(this.PeopleCounter, "PeopleCounter");
            this.PeopleCounter.Name = "PeopleCounter";
            // 
            // ProgressBar
            // 
            this.ProgressBar.Controls.Add(this.progressBar1);
            resources.ApplyResources(this.ProgressBar, "ProgressBar");
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.TabStop = false;
            // 
            // progressBar1
            // 
            resources.ApplyResources(this.progressBar1, "progressBar1");
            this.progressBar1.Name = "progressBar1";
            // 
            // ManualSave
            // 
            resources.ApplyResources(this.ManualSave, "ManualSave");
            this.ManualSave.Name = "ManualSave";
            this.ManualSave.UseVisualStyleBackColor = true;
            this.ManualSave.Click += new System.EventHandler(this.ManualSave_Click);
            // 
            // DelayShowing
            // 
            resources.ApplyResources(this.DelayShowing, "DelayShowing");
            this.DelayShowing.Name = "DelayShowing";
            this.DelayShowingToolTip.SetToolTip(this.DelayShowing, resources.GetString("DelayShowing.ToolTip"));
            this.DelayShowing.UseVisualStyleBackColor = true;
            // 
            // DelayShowingToolTip
            // 
            this.DelayShowingToolTip.ToolTipTitle = "갸차 모드?";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DelayShowing);
            this.Controls.Add(this.ManualSave);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.PeopleCount);
            this.Controls.Add(this.OTP);
            this.Controls.Add(this.SelectedUserAll);
            this.Controls.Add(this.MakePost);
            this.Controls.Add(this.SelectedUserCurr);
            this.Controls.Add(this.SelectingCount);
            this.Controls.Add(this.UserList);
            this.Controls.Add(this.UrlBox);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.UrlBox.ResumeLayout(false);
            this.UrlBox.PerformLayout();
            this.UserList.ResumeLayout(false);
            this.SelectingCount.ResumeLayout(false);
            this.SelectingCount.PerformLayout();
            this.SelectedUserCurr.ResumeLayout(false);
            this.SelectedUserAll.ResumeLayout(false);
            this.OTP.ResumeLayout(false);
            this.OTP.PerformLayout();
            this.PeopleCount.ResumeLayout(false);
            this.PeopleCount.PerformLayout();
            this.ProgressBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LinkButton;
        private System.Windows.Forms.TextBox LinkBox;
        private System.Windows.Forms.Button DrawButton;
        private System.Windows.Forms.ListView Users;
        private System.Windows.Forms.ColumnHeader UserName;
        private System.Windows.Forms.ColumnHeader UserComment;
        private System.Windows.Forms.ListView SelectedUserList;
        private System.Windows.Forms.ColumnHeader SelectedName;
        private System.Windows.Forms.ColumnHeader SelectedComment;
        private TextBox Count;
        private GroupBox UrlBox;
        private GroupBox UserList;
        private GroupBox SelectingCount;
        private GroupBox SelectedUserCurr;
        private Button MakePost;
        private GroupBox SelectedUserAll;
        private ListView AllUserList;
        private ColumnHeader AComment;
        private ColumnHeader Prize;
        private ColumnHeader NickName;
        private GroupBox OTP;
        private Button OTPButton;
        private TextBox OTPBox;
        private GroupBox PeopleCount;
        private Label PeopleCounter;
        private GroupBox ProgressBar;
        private ProgressBar progressBar1;
        private Button ManualSave;
        private CheckBox DelayShowing;
        private ToolTip DelayShowingToolTip;
    }
}

