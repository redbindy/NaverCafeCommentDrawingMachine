using System.Collections.Generic;

namespace NaverCafeCommentDrawingMachine
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
            this.MainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.TopLayout = new System.Windows.Forms.TableLayoutPanel();
            this.PostLinkGroup = new System.Windows.Forms.GroupBox();
            this.PostLinkGroupLayout = new System.Windows.Forms.TableLayoutPanel();
            this.LinkBox = new System.Windows.Forms.TextBox();
            this.LinkBoxButton = new System.Windows.Forms.Button();
            this.LoginNumbersGroup = new System.Windows.Forms.GroupBox();
            this.LoginNumbersLayout = new System.Windows.Forms.TableLayoutPanel();
            this.LoginNumbersBox = new System.Windows.Forms.TextBox();
            this.LoginNumbersButton = new System.Windows.Forms.Button();
            this.UserInfoGroup = new System.Windows.Forms.GroupBox();
            this.UserListView = new System.Windows.Forms.ListView();
            this.UserLIstEmptyColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UserListNickNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UserListCommentColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ControlLayout = new System.Windows.Forms.TableLayoutPanel();
            this.UserCountAndAnimationMode = new System.Windows.Forms.TableLayoutPanel();
            this.DrawingUserCountGroup = new System.Windows.Forms.GroupBox();
            this.DrawingUserCountLayout = new System.Windows.Forms.TableLayoutPanel();
            this.DrawingUserCountBox = new System.Windows.Forms.TextBox();
            this.DrawingUserButton = new System.Windows.Forms.Button();
            this.AnimationModeCheckBox = new System.Windows.Forms.CheckBox();
            this.UserTotalCountGroup = new System.Windows.Forms.GroupBox();
            this.UserTotalCountLabel = new System.Windows.Forms.Label();
            this.MenuBar = new System.Windows.Forms.MenuStrip();
            this.MenuBarSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBarGetPostFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBarMakePost = new System.Windows.Forms.ToolStripMenuItem();
            this.WinnerGroup = new System.Windows.Forms.GroupBox();
            this.WinnerTab = new System.Windows.Forms.TabControl();
            this.CurrentWinnerTab = new System.Windows.Forms.TabPage();
            this.CurrentWinnerListView = new System.Windows.Forms.ListView();
            this.CurrentWinnerListViewEmptyColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CurrentWinnerListViewNickNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CurrentWinnerListViewCommentColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CurrentWinnerListViewPrizeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AllWinnerTab = new System.Windows.Forms.TabPage();
            this.AllWinnerListView = new System.Windows.Forms.ListView();
            this.AllWinnerListViewEmptyColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AllWinnerListViewNickNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AllWinnerListViewCommnetColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AllWinnerListViewPrizeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LoginNumbersToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.MainLayout.SuspendLayout();
            this.TopLayout.SuspendLayout();
            this.PostLinkGroup.SuspendLayout();
            this.PostLinkGroupLayout.SuspendLayout();
            this.LoginNumbersGroup.SuspendLayout();
            this.LoginNumbersLayout.SuspendLayout();
            this.UserInfoGroup.SuspendLayout();
            this.ControlLayout.SuspendLayout();
            this.UserCountAndAnimationMode.SuspendLayout();
            this.DrawingUserCountGroup.SuspendLayout();
            this.DrawingUserCountLayout.SuspendLayout();
            this.UserTotalCountGroup.SuspendLayout();
            this.MenuBar.SuspendLayout();
            this.WinnerGroup.SuspendLayout();
            this.WinnerTab.SuspendLayout();
            this.CurrentWinnerTab.SuspendLayout();
            this.AllWinnerTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainLayout
            // 
            this.MainLayout.ColumnCount = 1;
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainLayout.Controls.Add(this.TopLayout, 0, 1);
            this.MainLayout.Controls.Add(this.UserInfoGroup, 0, 2);
            this.MainLayout.Controls.Add(this.ControlLayout, 0, 3);
            this.MainLayout.Controls.Add(this.MenuBar, 0, 0);
            this.MainLayout.Controls.Add(this.WinnerGroup, 0, 4);
            this.MainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayout.Location = new System.Drawing.Point(0, 0);
            this.MainLayout.Name = "MainLayout";
            this.MainLayout.RowCount = 5;
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42F));
            this.MainLayout.Size = new System.Drawing.Size(1264, 681);
            this.MainLayout.TabIndex = 0;
            // 
            // TopLayout
            // 
            this.TopLayout.ColumnCount = 2;
            this.TopLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TopLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TopLayout.Controls.Add(this.PostLinkGroup, 0, 0);
            this.TopLayout.Controls.Add(this.LoginNumbersGroup, 1, 0);
            this.TopLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopLayout.Location = new System.Drawing.Point(3, 30);
            this.TopLayout.Name = "TopLayout";
            this.TopLayout.RowCount = 1;
            this.TopLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TopLayout.Size = new System.Drawing.Size(1258, 62);
            this.TopLayout.TabIndex = 0;
            // 
            // PostLinkGroup
            // 
            this.PostLinkGroup.Controls.Add(this.PostLinkGroupLayout);
            this.PostLinkGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PostLinkGroup.Location = new System.Drawing.Point(3, 3);
            this.PostLinkGroup.Name = "PostLinkGroup";
            this.PostLinkGroup.Size = new System.Drawing.Size(623, 56);
            this.PostLinkGroup.TabIndex = 0;
            this.PostLinkGroup.TabStop = false;
            this.PostLinkGroup.Text = "게시글 주소 입력";
            // 
            // PostLinkGroupLayout
            // 
            this.PostLinkGroupLayout.ColumnCount = 2;
            this.PostLinkGroupLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.PostLinkGroupLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.PostLinkGroupLayout.Controls.Add(this.LinkBox, 0, 0);
            this.PostLinkGroupLayout.Controls.Add(this.LinkBoxButton, 1, 0);
            this.PostLinkGroupLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PostLinkGroupLayout.Location = new System.Drawing.Point(3, 17);
            this.PostLinkGroupLayout.Name = "PostLinkGroupLayout";
            this.PostLinkGroupLayout.RowCount = 1;
            this.PostLinkGroupLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PostLinkGroupLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.PostLinkGroupLayout.Size = new System.Drawing.Size(617, 36);
            this.PostLinkGroupLayout.TabIndex = 0;
            // 
            // LinkBox
            // 
            this.LinkBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LinkBox.Location = new System.Drawing.Point(3, 3);
            this.LinkBox.Name = "LinkBox";
            this.LinkBox.Size = new System.Drawing.Size(549, 21);
            this.LinkBox.TabIndex = 0;
            // 
            // LinkBoxButton
            // 
            this.LinkBoxButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LinkBoxButton.Location = new System.Drawing.Point(558, 3);
            this.LinkBoxButton.Name = "LinkBoxButton";
            this.LinkBoxButton.Size = new System.Drawing.Size(56, 30);
            this.LinkBoxButton.TabIndex = 1;
            this.LinkBoxButton.Text = "확인";
            this.LinkBoxButton.UseVisualStyleBackColor = true;
            // 
            // LoginNumbersGroup
            // 
            this.LoginNumbersGroup.Controls.Add(this.LoginNumbersLayout);
            this.LoginNumbersGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginNumbersGroup.Location = new System.Drawing.Point(632, 3);
            this.LoginNumbersGroup.Name = "LoginNumbersGroup";
            this.LoginNumbersGroup.Size = new System.Drawing.Size(623, 56);
            this.LoginNumbersGroup.TabIndex = 1;
            this.LoginNumbersGroup.TabStop = false;
            this.LoginNumbersGroup.Text = "일회용 로그인 번호 입력";
            // 
            // LoginNumbersLayout
            // 
            this.LoginNumbersLayout.ColumnCount = 2;
            this.LoginNumbersLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.LoginNumbersLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.LoginNumbersLayout.Controls.Add(this.LoginNumbersBox, 0, 0);
            this.LoginNumbersLayout.Controls.Add(this.LoginNumbersButton, 1, 0);
            this.LoginNumbersLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginNumbersLayout.Location = new System.Drawing.Point(3, 17);
            this.LoginNumbersLayout.Name = "LoginNumbersLayout";
            this.LoginNumbersLayout.RowCount = 1;
            this.LoginNumbersLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LoginNumbersLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.LoginNumbersLayout.Size = new System.Drawing.Size(617, 36);
            this.LoginNumbersLayout.TabIndex = 0;
            // 
            // LoginNumbersBox
            // 
            this.LoginNumbersBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginNumbersBox.Location = new System.Drawing.Point(3, 3);
            this.LoginNumbersBox.Name = "LoginNumbersBox";
            this.LoginNumbersBox.Size = new System.Drawing.Size(549, 21);
            this.LoginNumbersBox.TabIndex = 0;
            this.LoginNumbersBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LoginNumbersBox_KeyPress);
            // 
            // LoginNumbersButton
            // 
            this.LoginNumbersButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginNumbersButton.Location = new System.Drawing.Point(558, 3);
            this.LoginNumbersButton.Name = "LoginNumbersButton";
            this.LoginNumbersButton.Size = new System.Drawing.Size(56, 30);
            this.LoginNumbersButton.TabIndex = 1;
            this.LoginNumbersButton.Text = "확인";
            this.LoginNumbersButton.UseVisualStyleBackColor = true;
            this.LoginNumbersButton.Click += new System.EventHandler(this.LoginNumbersButton_Click);
            // 
            // UserInfoGroup
            // 
            this.UserInfoGroup.Controls.Add(this.UserListView);
            this.UserInfoGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserInfoGroup.Location = new System.Drawing.Point(3, 98);
            this.UserInfoGroup.Name = "UserInfoGroup";
            this.UserInfoGroup.Size = new System.Drawing.Size(1258, 198);
            this.UserInfoGroup.TabIndex = 1;
            this.UserInfoGroup.TabStop = false;
            this.UserInfoGroup.Text = "참여자 정보";
            // 
            // UserListView
            // 
            this.UserListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.UserLIstEmptyColumn,
            this.UserListNickNameColumn,
            this.UserListCommentColumn});
            this.UserListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserListView.HideSelection = false;
            this.UserListView.LabelWrap = false;
            this.UserListView.Location = new System.Drawing.Point(3, 17);
            this.UserListView.Name = "UserListView";
            this.UserListView.Size = new System.Drawing.Size(1252, 178);
            this.UserListView.TabIndex = 0;
            this.UserListView.UseCompatibleStateImageBehavior = false;
            this.UserListView.View = System.Windows.Forms.View.Details;
            // 
            // UserLIstEmptyColumn
            // 
            this.UserLIstEmptyColumn.Text = "";
            this.UserLIstEmptyColumn.Width = 0;
            // 
            // UserListNickNameColumn
            // 
            this.UserListNickNameColumn.Text = "별명";
            this.UserListNickNameColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UserListCommentColumn
            // 
            this.UserListCommentColumn.Text = "댓글";
            this.UserListCommentColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ControlLayout
            // 
            this.ControlLayout.ColumnCount = 3;
            this.ControlLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.31642F));
            this.ControlLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.90453F));
            this.ControlLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.77906F));
            this.ControlLayout.Controls.Add(this.UserCountAndAnimationMode, 0, 0);
            this.ControlLayout.Controls.Add(this.UserTotalCountGroup, 2, 0);
            this.ControlLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ControlLayout.Location = new System.Drawing.Point(3, 302);
            this.ControlLayout.Name = "ControlLayout";
            this.ControlLayout.RowCount = 1;
            this.ControlLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ControlLayout.Size = new System.Drawing.Size(1258, 89);
            this.ControlLayout.TabIndex = 2;
            // 
            // UserCountAndAnimationMode
            // 
            this.UserCountAndAnimationMode.ColumnCount = 1;
            this.UserCountAndAnimationMode.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.UserCountAndAnimationMode.Controls.Add(this.DrawingUserCountGroup, 0, 0);
            this.UserCountAndAnimationMode.Controls.Add(this.AnimationModeCheckBox, 0, 1);
            this.UserCountAndAnimationMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserCountAndAnimationMode.Location = new System.Drawing.Point(3, 3);
            this.UserCountAndAnimationMode.Name = "UserCountAndAnimationMode";
            this.UserCountAndAnimationMode.RowCount = 2;
            this.UserCountAndAnimationMode.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.UserCountAndAnimationMode.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.UserCountAndAnimationMode.Size = new System.Drawing.Size(199, 83);
            this.UserCountAndAnimationMode.TabIndex = 0;
            // 
            // DrawingUserCountGroup
            // 
            this.DrawingUserCountGroup.Controls.Add(this.DrawingUserCountLayout);
            this.DrawingUserCountGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DrawingUserCountGroup.Location = new System.Drawing.Point(3, 3);
            this.DrawingUserCountGroup.Name = "DrawingUserCountGroup";
            this.DrawingUserCountGroup.Size = new System.Drawing.Size(193, 52);
            this.DrawingUserCountGroup.TabIndex = 0;
            this.DrawingUserCountGroup.TabStop = false;
            this.DrawingUserCountGroup.Text = "인원수 입력";
            // 
            // DrawingUserCountLayout
            // 
            this.DrawingUserCountLayout.ColumnCount = 2;
            this.DrawingUserCountLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63F));
            this.DrawingUserCountLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37F));
            this.DrawingUserCountLayout.Controls.Add(this.DrawingUserCountBox, 0, 0);
            this.DrawingUserCountLayout.Controls.Add(this.DrawingUserButton, 1, 0);
            this.DrawingUserCountLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DrawingUserCountLayout.Location = new System.Drawing.Point(3, 17);
            this.DrawingUserCountLayout.Name = "DrawingUserCountLayout";
            this.DrawingUserCountLayout.RowCount = 1;
            this.DrawingUserCountLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.DrawingUserCountLayout.Size = new System.Drawing.Size(187, 32);
            this.DrawingUserCountLayout.TabIndex = 0;
            // 
            // DrawingUserCountBox
            // 
            this.DrawingUserCountBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DrawingUserCountBox.Location = new System.Drawing.Point(3, 3);
            this.DrawingUserCountBox.Name = "DrawingUserCountBox";
            this.DrawingUserCountBox.Size = new System.Drawing.Size(111, 21);
            this.DrawingUserCountBox.TabIndex = 0;
            // 
            // DrawingUserButton
            // 
            this.DrawingUserButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DrawingUserButton.Location = new System.Drawing.Point(120, 3);
            this.DrawingUserButton.Name = "DrawingUserButton";
            this.DrawingUserButton.Size = new System.Drawing.Size(64, 26);
            this.DrawingUserButton.TabIndex = 1;
            this.DrawingUserButton.Text = "추첨하기";
            this.DrawingUserButton.UseVisualStyleBackColor = true;
            // 
            // AnimationModeCheckBox
            // 
            this.AnimationModeCheckBox.AutoSize = true;
            this.AnimationModeCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AnimationModeCheckBox.Location = new System.Drawing.Point(3, 61);
            this.AnimationModeCheckBox.Name = "AnimationModeCheckBox";
            this.AnimationModeCheckBox.Size = new System.Drawing.Size(193, 19);
            this.AnimationModeCheckBox.TabIndex = 1;
            this.AnimationModeCheckBox.Text = "쪼는맛";
            this.AnimationModeCheckBox.UseVisualStyleBackColor = true;
            // 
            // UserTotalCountGroup
            // 
            this.UserTotalCountGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UserTotalCountGroup.Controls.Add(this.UserTotalCountLabel);
            this.UserTotalCountGroup.Location = new System.Drawing.Point(1001, 3);
            this.UserTotalCountGroup.Name = "UserTotalCountGroup";
            this.UserTotalCountGroup.Size = new System.Drawing.Size(254, 52);
            this.UserTotalCountGroup.TabIndex = 0;
            this.UserTotalCountGroup.TabStop = false;
            this.UserTotalCountGroup.Text = "인원수";
            // 
            // UserTotalCountLabel
            // 
            this.UserTotalCountLabel.AutoSize = true;
            this.UserTotalCountLabel.Location = new System.Drawing.Point(7, 17);
            this.UserTotalCountLabel.Name = "UserTotalCountLabel";
            this.UserTotalCountLabel.Size = new System.Drawing.Size(11, 12);
            this.UserTotalCountLabel.TabIndex = 0;
            this.UserTotalCountLabel.Text = "0";
            // 
            // MenuBar
            // 
            this.MenuBar.BackColor = System.Drawing.Color.Transparent;
            this.MenuBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenuBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.MenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuBarSave,
            this.toolStripMenuItem1,
            this.MenuBarGetPostFormat,
            this.MenuBarMakePost});
            this.MenuBar.Location = new System.Drawing.Point(0, 0);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Size = new System.Drawing.Size(1264, 27);
            this.MenuBar.TabIndex = 3;
            this.MenuBar.Text = "메뉴";
            // 
            // MenuBarSave
            // 
            this.MenuBarSave.Name = "MenuBarSave";
            this.MenuBarSave.Size = new System.Drawing.Size(43, 23);
            this.MenuBarSave.Text = "저장";
            this.MenuBarSave.ToolTipText = "전체 당첨자를 저장합니다. Ctrl + S";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 23);
            // 
            // MenuBarGetPostFormat
            // 
            this.MenuBarGetPostFormat.Name = "MenuBarGetPostFormat";
            this.MenuBarGetPostFormat.Size = new System.Drawing.Size(135, 23);
            this.MenuBarGetPostFormat.Text = "게시글 서식 불러오기";
            // 
            // MenuBarMakePost
            // 
            this.MenuBarMakePost.Name = "MenuBarMakePost";
            this.MenuBarMakePost.Size = new System.Drawing.Size(95, 23);
            this.MenuBarMakePost.Text = "게시글 만들기";
            // 
            // WinnerGroup
            // 
            this.WinnerGroup.Controls.Add(this.WinnerTab);
            this.WinnerGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WinnerGroup.Location = new System.Drawing.Point(3, 397);
            this.WinnerGroup.Name = "WinnerGroup";
            this.WinnerGroup.Size = new System.Drawing.Size(1258, 281);
            this.WinnerGroup.TabIndex = 4;
            this.WinnerGroup.TabStop = false;
            this.WinnerGroup.Text = "당첨자 정보";
            // 
            // WinnerTab
            // 
            this.WinnerTab.Controls.Add(this.CurrentWinnerTab);
            this.WinnerTab.Controls.Add(this.AllWinnerTab);
            this.WinnerTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WinnerTab.Location = new System.Drawing.Point(3, 17);
            this.WinnerTab.Name = "WinnerTab";
            this.WinnerTab.SelectedIndex = 0;
            this.WinnerTab.Size = new System.Drawing.Size(1252, 261);
            this.WinnerTab.TabIndex = 0;
            // 
            // CurrentWinnerTab
            // 
            this.CurrentWinnerTab.Controls.Add(this.CurrentWinnerListView);
            this.CurrentWinnerTab.Location = new System.Drawing.Point(4, 22);
            this.CurrentWinnerTab.Name = "CurrentWinnerTab";
            this.CurrentWinnerTab.Padding = new System.Windows.Forms.Padding(3);
            this.CurrentWinnerTab.Size = new System.Drawing.Size(1244, 235);
            this.CurrentWinnerTab.TabIndex = 0;
            this.CurrentWinnerTab.Text = "당첨자";
            this.CurrentWinnerTab.UseVisualStyleBackColor = true;
            // 
            // CurrentWinnerListView
            // 
            this.CurrentWinnerListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CurrentWinnerListViewEmptyColumn,
            this.CurrentWinnerListViewNickNameColumn,
            this.CurrentWinnerListViewCommentColumn,
            this.CurrentWinnerListViewPrizeColumn});
            this.CurrentWinnerListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CurrentWinnerListView.HideSelection = false;
            this.CurrentWinnerListView.Location = new System.Drawing.Point(3, 3);
            this.CurrentWinnerListView.Name = "CurrentWinnerListView";
            this.CurrentWinnerListView.Size = new System.Drawing.Size(1238, 229);
            this.CurrentWinnerListView.TabIndex = 0;
            this.CurrentWinnerListView.UseCompatibleStateImageBehavior = false;
            this.CurrentWinnerListView.View = System.Windows.Forms.View.Details;
            // 
            // CurrentWinnerListViewEmptyColumn
            // 
            this.CurrentWinnerListViewEmptyColumn.Text = "";
            this.CurrentWinnerListViewEmptyColumn.Width = 0;
            // 
            // CurrentWinnerListViewNickNameColumn
            // 
            this.CurrentWinnerListViewNickNameColumn.Text = "별명";
            this.CurrentWinnerListViewNickNameColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CurrentWinnerListViewCommentColumn
            // 
            this.CurrentWinnerListViewCommentColumn.Text = "댓글";
            this.CurrentWinnerListViewCommentColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CurrentWinnerListViewPrizeColumn
            // 
            this.CurrentWinnerListViewPrizeColumn.Text = "상품";
            this.CurrentWinnerListViewPrizeColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AllWinnerTab
            // 
            this.AllWinnerTab.Controls.Add(this.AllWinnerListView);
            this.AllWinnerTab.Location = new System.Drawing.Point(4, 22);
            this.AllWinnerTab.Name = "AllWinnerTab";
            this.AllWinnerTab.Padding = new System.Windows.Forms.Padding(3);
            this.AllWinnerTab.Size = new System.Drawing.Size(1244, 235);
            this.AllWinnerTab.TabIndex = 1;
            this.AllWinnerTab.Text = "전체 당첨자";
            this.AllWinnerTab.UseVisualStyleBackColor = true;
            // 
            // AllWinnerListView
            // 
            this.AllWinnerListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.AllWinnerListViewEmptyColumn,
            this.AllWinnerListViewNickNameColumn,
            this.AllWinnerListViewCommnetColumn,
            this.AllWinnerListViewPrizeColumn});
            this.AllWinnerListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AllWinnerListView.HideSelection = false;
            this.AllWinnerListView.Location = new System.Drawing.Point(3, 3);
            this.AllWinnerListView.Name = "AllWinnerListView";
            this.AllWinnerListView.Size = new System.Drawing.Size(1238, 229);
            this.AllWinnerListView.TabIndex = 0;
            this.AllWinnerListView.UseCompatibleStateImageBehavior = false;
            this.AllWinnerListView.View = System.Windows.Forms.View.Details;
            // 
            // AllWinnerListViewEmptyColumn
            // 
            this.AllWinnerListViewEmptyColumn.Text = "";
            this.AllWinnerListViewEmptyColumn.Width = 0;
            // 
            // AllWinnerListViewNickNameColumn
            // 
            this.AllWinnerListViewNickNameColumn.Text = "별명";
            this.AllWinnerListViewNickNameColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AllWinnerListViewCommnetColumn
            // 
            this.AllWinnerListViewCommnetColumn.Text = "댓글";
            this.AllWinnerListViewCommnetColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AllWinnerListViewPrizeColumn
            // 
            this.AllWinnerListViewPrizeColumn.Text = "상품";
            this.AllWinnerListViewPrizeColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.MainLayout);
            this.MainMenuStrip = this.MenuBar;
            this.Name = "Form1";
            this.Text = "네이버 카페 댓글 추첨기";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MainLayout.ResumeLayout(false);
            this.MainLayout.PerformLayout();
            this.TopLayout.ResumeLayout(false);
            this.PostLinkGroup.ResumeLayout(false);
            this.PostLinkGroupLayout.ResumeLayout(false);
            this.PostLinkGroupLayout.PerformLayout();
            this.LoginNumbersGroup.ResumeLayout(false);
            this.LoginNumbersLayout.ResumeLayout(false);
            this.LoginNumbersLayout.PerformLayout();
            this.UserInfoGroup.ResumeLayout(false);
            this.ControlLayout.ResumeLayout(false);
            this.UserCountAndAnimationMode.ResumeLayout(false);
            this.UserCountAndAnimationMode.PerformLayout();
            this.DrawingUserCountGroup.ResumeLayout(false);
            this.DrawingUserCountLayout.ResumeLayout(false);
            this.DrawingUserCountLayout.PerformLayout();
            this.UserTotalCountGroup.ResumeLayout(false);
            this.UserTotalCountGroup.PerformLayout();
            this.MenuBar.ResumeLayout(false);
            this.MenuBar.PerformLayout();
            this.WinnerGroup.ResumeLayout(false);
            this.WinnerTab.ResumeLayout(false);
            this.CurrentWinnerTab.ResumeLayout(false);
            this.AllWinnerTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainLayout;
        private System.Windows.Forms.TableLayoutPanel TopLayout;
        private System.Windows.Forms.GroupBox PostLinkGroup;
        private System.Windows.Forms.TableLayoutPanel PostLinkGroupLayout;
        private System.Windows.Forms.TextBox LinkBox;
        private System.Windows.Forms.Button LinkBoxButton;
        private System.Windows.Forms.GroupBox LoginNumbersGroup;
        private System.Windows.Forms.TableLayoutPanel LoginNumbersLayout;
        private System.Windows.Forms.TextBox LoginNumbersBox;
        private System.Windows.Forms.Button LoginNumbersButton;
        private System.Windows.Forms.GroupBox UserInfoGroup;
        private System.Windows.Forms.ListView UserListView;
        private System.Windows.Forms.ColumnHeader UserLIstEmptyColumn;
        private System.Windows.Forms.ColumnHeader UserListNickNameColumn;
        private System.Windows.Forms.ColumnHeader UserListCommentColumn;
        private System.Windows.Forms.TableLayoutPanel ControlLayout;
        private System.Windows.Forms.TableLayoutPanel UserCountAndAnimationMode;
        private System.Windows.Forms.GroupBox DrawingUserCountGroup;
        private System.Windows.Forms.TableLayoutPanel DrawingUserCountLayout;
        private System.Windows.Forms.TextBox DrawingUserCountBox;
        private System.Windows.Forms.Button DrawingUserButton;
        private System.Windows.Forms.CheckBox AnimationModeCheckBox;
        private System.Windows.Forms.GroupBox UserTotalCountGroup;
        private System.Windows.Forms.Label UserTotalCountLabel;
        private System.Windows.Forms.MenuStrip MenuBar;
        private System.Windows.Forms.ToolStripMenuItem MenuBarSave;
        private System.Windows.Forms.GroupBox WinnerGroup;
        private System.Windows.Forms.TabControl WinnerTab;
        private System.Windows.Forms.TabPage CurrentWinnerTab;
        private System.Windows.Forms.TabPage AllWinnerTab;
        private System.Windows.Forms.ListView CurrentWinnerListView;
        private System.Windows.Forms.ColumnHeader CurrentWinnerListViewEmptyColumn;
        private System.Windows.Forms.ColumnHeader CurrentWinnerListViewNickNameColumn;
        private System.Windows.Forms.ColumnHeader CurrentWinnerListViewCommentColumn;
        private System.Windows.Forms.ColumnHeader CurrentWinnerListViewPrizeColumn;
        private System.Windows.Forms.ListView AllWinnerListView;
        private System.Windows.Forms.ColumnHeader AllWinnerListViewEmptyColumn;
        private System.Windows.Forms.ColumnHeader AllWinnerListViewNickNameColumn;
        private System.Windows.Forms.ColumnHeader AllWinnerListViewCommnetColumn;
        private System.Windows.Forms.ColumnHeader AllWinnerListViewPrizeColumn;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem MenuBarGetPostFormat;
        private System.Windows.Forms.ToolStripMenuItem MenuBarMakePost;
        private System.Windows.Forms.ToolTip LoginNumbersToolTip;
    }
}

