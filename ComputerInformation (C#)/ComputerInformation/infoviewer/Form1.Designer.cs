namespace infoviewer
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listComps = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageCPU = new System.Windows.Forms.TabPage();
            this.CPU_info = new BrightIdeasSoftware.TreeListView();
            this.tabPageDiskDrive = new System.Windows.Forms.TabPage();
            this.tabPageDev = new System.Windows.Forms.TabPage();
            this.tabPageGC = new System.Windows.Forms.TabPage();
            this.tabPageMB = new System.Windows.Forms.TabPage();
            this.tabPageNet = new System.Windows.Forms.TabPage();
            this.tabPageOS = new System.Windows.Forms.TabPage();
            this.tabPageRAM = new System.Windows.Forms.TabPage();
            this.tabPageRAM2 = new System.Windows.Forms.TabPage();
            this.tabPageSoft = new System.Windows.Forms.TabPage();
            this.DD_info = new BrightIdeasSoftware.TreeListView();
            this.Dev_info = new BrightIdeasSoftware.TreeListView();
            this.GC_info = new BrightIdeasSoftware.TreeListView();
            this.MB_info = new BrightIdeasSoftware.TreeListView();
            this.Net_info = new BrightIdeasSoftware.TreeListView();
            this.OS_info = new BrightIdeasSoftware.TreeListView();
            this.RAM_info = new BrightIdeasSoftware.TreeListView();
            this.RAM2_info = new BrightIdeasSoftware.TreeListView();
            this.Soft_info = new BrightIdeasSoftware.TreeListView();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageCPU.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CPU_info)).BeginInit();
            this.tabPageDiskDrive.SuspendLayout();
            this.tabPageDev.SuspendLayout();
            this.tabPageGC.SuspendLayout();
            this.tabPageMB.SuspendLayout();
            this.tabPageNet.SuspendLayout();
            this.tabPageOS.SuspendLayout();
            this.tabPageRAM.SuspendLayout();
            this.tabPageRAM2.SuspendLayout();
            this.tabPageSoft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DD_info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dev_info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GC_info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MB_info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Net_info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OS_info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RAM_info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RAM2_info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Soft_info)).BeginInit();
            this.SuspendLayout();
            // 
            // listComps
            // 
            this.listComps.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listComps.FormattingEnabled = true;
            this.listComps.Location = new System.Drawing.Point(12, 27);
            this.listComps.Name = "listComps";
            this.listComps.Size = new System.Drawing.Size(205, 472);
            this.listComps.TabIndex = 0;
            this.listComps.SelectedIndexChanged += new System.EventHandler(this.listComps_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(867, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "123";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageCPU);
            this.tabControl1.Controls.Add(this.tabPageDiskDrive);
            this.tabControl1.Controls.Add(this.tabPageDev);
            this.tabControl1.Controls.Add(this.tabPageGC);
            this.tabControl1.Controls.Add(this.tabPageMB);
            this.tabControl1.Controls.Add(this.tabPageNet);
            this.tabControl1.Controls.Add(this.tabPageOS);
            this.tabControl1.Controls.Add(this.tabPageRAM);
            this.tabControl1.Controls.Add(this.tabPageRAM2);
            this.tabControl1.Controls.Add(this.tabPageSoft);
            this.tabControl1.Location = new System.Drawing.Point(223, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(632, 473);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPageCPU
            // 
            this.tabPageCPU.Controls.Add(this.CPU_info);
            this.tabPageCPU.Location = new System.Drawing.Point(4, 22);
            this.tabPageCPU.Name = "tabPageCPU";
            this.tabPageCPU.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCPU.Size = new System.Drawing.Size(624, 447);
            this.tabPageCPU.TabIndex = 0;
            this.tabPageCPU.Text = "CPU";
            this.tabPageCPU.UseVisualStyleBackColor = true;
            // 
            // CPU_info
            // 
            this.CPU_info.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CPU_info.CellEditUseWholeCell = false;
            this.CPU_info.HideSelection = false;
            this.CPU_info.Location = new System.Drawing.Point(6, 6);
            this.CPU_info.Name = "CPU_info";
            this.CPU_info.ShowGroups = false;
            this.CPU_info.Size = new System.Drawing.Size(612, 435);
            this.CPU_info.TabIndex = 4;
            this.CPU_info.UseCompatibleStateImageBehavior = false;
            this.CPU_info.View = System.Windows.Forms.View.Details;
            this.CPU_info.VirtualMode = true;
            // 
            // tabPageDiskDrive
            // 
            this.tabPageDiskDrive.Controls.Add(this.DD_info);
            this.tabPageDiskDrive.Location = new System.Drawing.Point(4, 22);
            this.tabPageDiskDrive.Name = "tabPageDiskDrive";
            this.tabPageDiskDrive.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDiskDrive.Size = new System.Drawing.Size(624, 447);
            this.tabPageDiskDrive.TabIndex = 1;
            this.tabPageDiskDrive.Text = "DiskDrive";
            this.tabPageDiskDrive.UseVisualStyleBackColor = true;
            // 
            // tabPageDev
            // 
            this.tabPageDev.Controls.Add(this.Dev_info);
            this.tabPageDev.Location = new System.Drawing.Point(4, 22);
            this.tabPageDev.Name = "tabPageDev";
            this.tabPageDev.Size = new System.Drawing.Size(624, 447);
            this.tabPageDev.TabIndex = 2;
            this.tabPageDev.Text = "Devices";
            this.tabPageDev.UseVisualStyleBackColor = true;
            // 
            // tabPageGC
            // 
            this.tabPageGC.Controls.Add(this.GC_info);
            this.tabPageGC.Location = new System.Drawing.Point(4, 22);
            this.tabPageGC.Name = "tabPageGC";
            this.tabPageGC.Size = new System.Drawing.Size(624, 447);
            this.tabPageGC.TabIndex = 3;
            this.tabPageGC.Text = "Graphic Card";
            this.tabPageGC.UseVisualStyleBackColor = true;
            // 
            // tabPageMB
            // 
            this.tabPageMB.Controls.Add(this.MB_info);
            this.tabPageMB.Location = new System.Drawing.Point(4, 22);
            this.tabPageMB.Name = "tabPageMB";
            this.tabPageMB.Size = new System.Drawing.Size(624, 447);
            this.tabPageMB.TabIndex = 4;
            this.tabPageMB.Text = "MotherBoard";
            this.tabPageMB.UseVisualStyleBackColor = true;
            // 
            // tabPageNet
            // 
            this.tabPageNet.Controls.Add(this.Net_info);
            this.tabPageNet.Location = new System.Drawing.Point(4, 22);
            this.tabPageNet.Name = "tabPageNet";
            this.tabPageNet.Size = new System.Drawing.Size(624, 447);
            this.tabPageNet.TabIndex = 5;
            this.tabPageNet.Text = "Network";
            this.tabPageNet.UseVisualStyleBackColor = true;
            // 
            // tabPageOS
            // 
            this.tabPageOS.Controls.Add(this.OS_info);
            this.tabPageOS.Location = new System.Drawing.Point(4, 22);
            this.tabPageOS.Name = "tabPageOS";
            this.tabPageOS.Size = new System.Drawing.Size(624, 447);
            this.tabPageOS.TabIndex = 6;
            this.tabPageOS.Text = "Operating system";
            this.tabPageOS.UseVisualStyleBackColor = true;
            // 
            // tabPageRAM
            // 
            this.tabPageRAM.Controls.Add(this.RAM_info);
            this.tabPageRAM.Location = new System.Drawing.Point(4, 22);
            this.tabPageRAM.Name = "tabPageRAM";
            this.tabPageRAM.Size = new System.Drawing.Size(624, 447);
            this.tabPageRAM.TabIndex = 7;
            this.tabPageRAM.Text = "RAM";
            this.tabPageRAM.UseVisualStyleBackColor = true;
            // 
            // tabPageRAM2
            // 
            this.tabPageRAM2.Controls.Add(this.RAM2_info);
            this.tabPageRAM2.Location = new System.Drawing.Point(4, 22);
            this.tabPageRAM2.Name = "tabPageRAM2";
            this.tabPageRAM2.Size = new System.Drawing.Size(624, 447);
            this.tabPageRAM2.TabIndex = 8;
            this.tabPageRAM2.Text = "RAM2";
            this.tabPageRAM2.UseVisualStyleBackColor = true;
            // 
            // tabPageSoft
            // 
            this.tabPageSoft.Controls.Add(this.Soft_info);
            this.tabPageSoft.Location = new System.Drawing.Point(4, 22);
            this.tabPageSoft.Name = "tabPageSoft";
            this.tabPageSoft.Size = new System.Drawing.Size(624, 447);
            this.tabPageSoft.TabIndex = 9;
            this.tabPageSoft.Text = "Software";
            this.tabPageSoft.UseVisualStyleBackColor = true;
            // 
            // DD_info
            // 
            this.DD_info.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DD_info.CellEditUseWholeCell = false;
            this.DD_info.HideSelection = false;
            this.DD_info.Location = new System.Drawing.Point(6, 6);
            this.DD_info.Name = "DD_info";
            this.DD_info.ShowGroups = false;
            this.DD_info.Size = new System.Drawing.Size(612, 435);
            this.DD_info.TabIndex = 5;
            this.DD_info.UseCompatibleStateImageBehavior = false;
            this.DD_info.View = System.Windows.Forms.View.Details;
            this.DD_info.VirtualMode = true;
            // 
            // Dev_info
            // 
            this.Dev_info.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dev_info.CellEditUseWholeCell = false;
            this.Dev_info.HideSelection = false;
            this.Dev_info.Location = new System.Drawing.Point(6, 6);
            this.Dev_info.Name = "Dev_info";
            this.Dev_info.ShowGroups = false;
            this.Dev_info.Size = new System.Drawing.Size(612, 435);
            this.Dev_info.TabIndex = 5;
            this.Dev_info.UseCompatibleStateImageBehavior = false;
            this.Dev_info.View = System.Windows.Forms.View.Details;
            this.Dev_info.VirtualMode = true;
            // 
            // GC_info
            // 
            this.GC_info.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GC_info.CellEditUseWholeCell = false;
            this.GC_info.HideSelection = false;
            this.GC_info.Location = new System.Drawing.Point(6, 6);
            this.GC_info.Name = "GC_info";
            this.GC_info.ShowGroups = false;
            this.GC_info.Size = new System.Drawing.Size(612, 435);
            this.GC_info.TabIndex = 5;
            this.GC_info.UseCompatibleStateImageBehavior = false;
            this.GC_info.View = System.Windows.Forms.View.Details;
            this.GC_info.VirtualMode = true;
            // 
            // MB_info
            // 
            this.MB_info.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MB_info.CellEditUseWholeCell = false;
            this.MB_info.HideSelection = false;
            this.MB_info.Location = new System.Drawing.Point(6, 6);
            this.MB_info.Name = "MB_info";
            this.MB_info.ShowGroups = false;
            this.MB_info.Size = new System.Drawing.Size(612, 435);
            this.MB_info.TabIndex = 5;
            this.MB_info.UseCompatibleStateImageBehavior = false;
            this.MB_info.View = System.Windows.Forms.View.Details;
            this.MB_info.VirtualMode = true;
            // 
            // Net_info
            // 
            this.Net_info.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Net_info.CellEditUseWholeCell = false;
            this.Net_info.HideSelection = false;
            this.Net_info.Location = new System.Drawing.Point(6, 6);
            this.Net_info.Name = "Net_info";
            this.Net_info.ShowGroups = false;
            this.Net_info.Size = new System.Drawing.Size(612, 435);
            this.Net_info.TabIndex = 5;
            this.Net_info.UseCompatibleStateImageBehavior = false;
            this.Net_info.View = System.Windows.Forms.View.Details;
            this.Net_info.VirtualMode = true;
            // 
            // OS_info
            // 
            this.OS_info.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OS_info.CellEditUseWholeCell = false;
            this.OS_info.HideSelection = false;
            this.OS_info.Location = new System.Drawing.Point(6, 6);
            this.OS_info.Name = "OS_info";
            this.OS_info.ShowGroups = false;
            this.OS_info.Size = new System.Drawing.Size(612, 435);
            this.OS_info.TabIndex = 5;
            this.OS_info.UseCompatibleStateImageBehavior = false;
            this.OS_info.View = System.Windows.Forms.View.Details;
            this.OS_info.VirtualMode = true;
            // 
            // RAM_info
            // 
            this.RAM_info.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RAM_info.CellEditUseWholeCell = false;
            this.RAM_info.HideSelection = false;
            this.RAM_info.Location = new System.Drawing.Point(6, 6);
            this.RAM_info.Name = "RAM_info";
            this.RAM_info.ShowGroups = false;
            this.RAM_info.Size = new System.Drawing.Size(612, 435);
            this.RAM_info.TabIndex = 5;
            this.RAM_info.UseCompatibleStateImageBehavior = false;
            this.RAM_info.View = System.Windows.Forms.View.Details;
            this.RAM_info.VirtualMode = true;
            // 
            // RAM2_info
            // 
            this.RAM2_info.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RAM2_info.CellEditUseWholeCell = false;
            this.RAM2_info.HideSelection = false;
            this.RAM2_info.Location = new System.Drawing.Point(6, 6);
            this.RAM2_info.Name = "RAM2_info";
            this.RAM2_info.ShowGroups = false;
            this.RAM2_info.Size = new System.Drawing.Size(612, 435);
            this.RAM2_info.TabIndex = 5;
            this.RAM2_info.UseCompatibleStateImageBehavior = false;
            this.RAM2_info.View = System.Windows.Forms.View.Details;
            this.RAM2_info.VirtualMode = true;
            // 
            // Soft_info
            // 
            this.Soft_info.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Soft_info.CellEditUseWholeCell = false;
            this.Soft_info.HideSelection = false;
            this.Soft_info.Location = new System.Drawing.Point(6, 6);
            this.Soft_info.Name = "Soft_info";
            this.Soft_info.ShowGroups = false;
            this.Soft_info.Size = new System.Drawing.Size(612, 435);
            this.Soft_info.TabIndex = 5;
            this.Soft_info.UseCompatibleStateImageBehavior = false;
            this.Soft_info.View = System.Windows.Forms.View.Details;
            this.Soft_info.VirtualMode = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 512);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.listComps);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageCPU.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CPU_info)).EndInit();
            this.tabPageDiskDrive.ResumeLayout(false);
            this.tabPageDev.ResumeLayout(false);
            this.tabPageGC.ResumeLayout(false);
            this.tabPageMB.ResumeLayout(false);
            this.tabPageNet.ResumeLayout(false);
            this.tabPageOS.ResumeLayout(false);
            this.tabPageRAM.ResumeLayout(false);
            this.tabPageRAM2.ResumeLayout(false);
            this.tabPageSoft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DD_info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dev_info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GC_info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MB_info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Net_info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OS_info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RAM_info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RAM2_info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Soft_info)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listComps;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageCPU;
        private System.Windows.Forms.TabPage tabPageDiskDrive;
        private System.Windows.Forms.TabPage tabPageDev;
        private System.Windows.Forms.TabPage tabPageGC;
        private System.Windows.Forms.TabPage tabPageMB;
        private System.Windows.Forms.TabPage tabPageNet;
        private System.Windows.Forms.TabPage tabPageOS;
        private System.Windows.Forms.TabPage tabPageRAM;
        private System.Windows.Forms.TabPage tabPageRAM2;
        private System.Windows.Forms.TabPage tabPageSoft;
        private BrightIdeasSoftware.TreeListView CPU_info;
        private BrightIdeasSoftware.TreeListView DD_info;
        private BrightIdeasSoftware.TreeListView Dev_info;
        private BrightIdeasSoftware.TreeListView GC_info;
        private BrightIdeasSoftware.TreeListView MB_info;
        private BrightIdeasSoftware.TreeListView Net_info;
        private BrightIdeasSoftware.TreeListView OS_info;
        private BrightIdeasSoftware.TreeListView RAM_info;
        private BrightIdeasSoftware.TreeListView RAM2_info;
        private BrightIdeasSoftware.TreeListView Soft_info;
    }
}

