namespace WorkOrders
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
            this.tb = new System.Windows.Forms.TabControl();
            this.tbInfo = new System.Windows.Forms.TabPage();
            this.dtInfo = new System.Windows.Forms.DataGridView();
            this.tbComments = new System.Windows.Forms.TabPage();
            this.dtComments = new System.Windows.Forms.DataGridView();
            this.tbBookedHours = new System.Windows.Forms.TabPage();
            this.dtBookedHours = new System.Windows.Forms.DataGridView();
            this.tbDocuments = new System.Windows.Forms.TabPage();
            this.dtDocuments = new System.Windows.Forms.DataGridView();
            this.tbMaterials = new System.Windows.Forms.TabPage();
            this.dtMaterials = new System.Windows.Forms.DataGridView();
            this.tbLogs = new System.Windows.Forms.TabPage();
            this.dtLogs = new System.Windows.Forms.DataGridView();
            this.tbControlLists = new System.Windows.Forms.TabPage();
            this.dtControlLists = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.WorkOrderList = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbActivity = new System.Windows.Forms.TabPage();
            this.dtActivity = new System.Windows.Forms.DataGridView();
            this.tb.SuspendLayout();
            this.tbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtInfo)).BeginInit();
            this.tbComments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtComments)).BeginInit();
            this.tbBookedHours.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtBookedHours)).BeginInit();
            this.tbDocuments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtDocuments)).BeginInit();
            this.tbMaterials.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtMaterials)).BeginInit();
            this.tbLogs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtLogs)).BeginInit();
            this.tbControlLists.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtControlLists)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkOrderList)).BeginInit();
            this.tbActivity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtActivity)).BeginInit();
            this.SuspendLayout();
            // 
            // tb
            // 
            this.tb.Controls.Add(this.tbInfo);
            this.tb.Controls.Add(this.tbComments);
            this.tb.Controls.Add(this.tbBookedHours);
            this.tb.Controls.Add(this.tbDocuments);
            this.tb.Controls.Add(this.tbMaterials);
            this.tb.Controls.Add(this.tbLogs);
            this.tb.Controls.Add(this.tbControlLists);
            this.tb.Controls.Add(this.tbActivity);
            this.tb.Location = new System.Drawing.Point(352, 75);
            this.tb.Name = "tb";
            this.tb.SelectedIndex = 0;
            this.tb.Size = new System.Drawing.Size(736, 366);
            this.tb.TabIndex = 18;
            // 
            // tbInfo
            // 
            this.tbInfo.Controls.Add(this.dtInfo);
            this.tbInfo.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInfo.Location = new System.Drawing.Point(4, 25);
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbInfo.Size = new System.Drawing.Size(728, 337);
            this.tbInfo.TabIndex = 1;
            this.tbInfo.Text = "Info";
            this.tbInfo.UseVisualStyleBackColor = true;
            // 
            // dtInfo
            // 
            this.dtInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtInfo.Location = new System.Drawing.Point(0, 3);
            this.dtInfo.Name = "dtInfo";
            this.dtInfo.RowTemplate.Height = 24;
            this.dtInfo.Size = new System.Drawing.Size(728, 338);
            this.dtInfo.TabIndex = 0;
            // 
            // tbComments
            // 
            this.tbComments.Controls.Add(this.dtComments);
            this.tbComments.Location = new System.Drawing.Point(4, 25);
            this.tbComments.Name = "tbComments";
            this.tbComments.Padding = new System.Windows.Forms.Padding(3);
            this.tbComments.Size = new System.Drawing.Size(728, 337);
            this.tbComments.TabIndex = 2;
            this.tbComments.Text = "Comments";
            this.tbComments.UseVisualStyleBackColor = true;
            // 
            // dtComments
            // 
            this.dtComments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtComments.Location = new System.Drawing.Point(0, 1);
            this.dtComments.Name = "dtComments";
            this.dtComments.RowTemplate.Height = 24;
            this.dtComments.Size = new System.Drawing.Size(728, 340);
            this.dtComments.TabIndex = 1;
            // 
            // tbBookedHours
            // 
            this.tbBookedHours.Controls.Add(this.dtBookedHours);
            this.tbBookedHours.Location = new System.Drawing.Point(4, 25);
            this.tbBookedHours.Name = "tbBookedHours";
            this.tbBookedHours.Padding = new System.Windows.Forms.Padding(3);
            this.tbBookedHours.Size = new System.Drawing.Size(728, 337);
            this.tbBookedHours.TabIndex = 3;
            this.tbBookedHours.Text = "BookedHours";
            this.tbBookedHours.UseVisualStyleBackColor = true;
            // 
            // dtBookedHours
            // 
            this.dtBookedHours.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtBookedHours.Location = new System.Drawing.Point(0, 1);
            this.dtBookedHours.Name = "dtBookedHours";
            this.dtBookedHours.RowTemplate.Height = 24;
            this.dtBookedHours.Size = new System.Drawing.Size(728, 340);
            this.dtBookedHours.TabIndex = 1;
            // 
            // tbDocuments
            // 
            this.tbDocuments.Controls.Add(this.dtDocuments);
            this.tbDocuments.Location = new System.Drawing.Point(4, 25);
            this.tbDocuments.Name = "tbDocuments";
            this.tbDocuments.Padding = new System.Windows.Forms.Padding(3);
            this.tbDocuments.Size = new System.Drawing.Size(728, 337);
            this.tbDocuments.TabIndex = 4;
            this.tbDocuments.Text = "Documents";
            this.tbDocuments.UseVisualStyleBackColor = true;
            // 
            // dtDocuments
            // 
            this.dtDocuments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtDocuments.Location = new System.Drawing.Point(0, 1);
            this.dtDocuments.Name = "dtDocuments";
            this.dtDocuments.RowTemplate.Height = 24;
            this.dtDocuments.Size = new System.Drawing.Size(728, 340);
            this.dtDocuments.TabIndex = 1;
            // 
            // tbMaterials
            // 
            this.tbMaterials.Controls.Add(this.dtMaterials);
            this.tbMaterials.Location = new System.Drawing.Point(4, 25);
            this.tbMaterials.Name = "tbMaterials";
            this.tbMaterials.Padding = new System.Windows.Forms.Padding(3);
            this.tbMaterials.Size = new System.Drawing.Size(728, 337);
            this.tbMaterials.TabIndex = 5;
            this.tbMaterials.Text = "Materials";
            this.tbMaterials.UseVisualStyleBackColor = true;
            // 
            // dtMaterials
            // 
            this.dtMaterials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtMaterials.Location = new System.Drawing.Point(0, 1);
            this.dtMaterials.Name = "dtMaterials";
            this.dtMaterials.RowTemplate.Height = 24;
            this.dtMaterials.Size = new System.Drawing.Size(728, 340);
            this.dtMaterials.TabIndex = 1;
            // 
            // tbLogs
            // 
            this.tbLogs.Controls.Add(this.dtLogs);
            this.tbLogs.Location = new System.Drawing.Point(4, 25);
            this.tbLogs.Name = "tbLogs";
            this.tbLogs.Padding = new System.Windows.Forms.Padding(3);
            this.tbLogs.Size = new System.Drawing.Size(728, 337);
            this.tbLogs.TabIndex = 6;
            this.tbLogs.Text = "Logs";
            this.tbLogs.UseVisualStyleBackColor = true;
            // 
            // dtLogs
            // 
            this.dtLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtLogs.Location = new System.Drawing.Point(0, 0);
            this.dtLogs.Name = "dtLogs";
            this.dtLogs.RowTemplate.Height = 24;
            this.dtLogs.Size = new System.Drawing.Size(725, 334);
            this.dtLogs.TabIndex = 2;
            // 
            // tbControlLists
            // 
            this.tbControlLists.Controls.Add(this.dtControlLists);
            this.tbControlLists.Location = new System.Drawing.Point(4, 25);
            this.tbControlLists.Name = "tbControlLists";
            this.tbControlLists.Padding = new System.Windows.Forms.Padding(3);
            this.tbControlLists.Size = new System.Drawing.Size(728, 337);
            this.tbControlLists.TabIndex = 7;
            this.tbControlLists.Text = "Control List";
            this.tbControlLists.UseVisualStyleBackColor = true;
            // 
            // dtControlLists
            // 
            this.dtControlLists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtControlLists.Location = new System.Drawing.Point(2, 1);
            this.dtControlLists.Name = "dtControlLists";
            this.dtControlLists.RowTemplate.Height = 24;
            this.dtControlLists.Size = new System.Drawing.Size(725, 330);
            this.dtControlLists.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(115, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 23);
            this.label2.TabIndex = 17;
            this.label2.Text = "Work Orders";
            // 
            // WorkOrderList
            // 
            this.WorkOrderList.AllowUserToOrderColumns = true;
            this.WorkOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WorkOrderList.Location = new System.Drawing.Point(12, 75);
            this.WorkOrderList.MultiSelect = false;
            this.WorkOrderList.Name = "WorkOrderList";
            this.WorkOrderList.RowTemplate.Height = 24;
            this.WorkOrderList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.WorkOrderList.Size = new System.Drawing.Size(334, 366);
            this.WorkOrderList.TabIndex = 16;
            this.WorkOrderList.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.WorkOrderList_CellContentDoubleClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(88, 38);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(258, 30);
            this.txtSearch.TabIndex = 15;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "Search:";
            // 
            // tbActivity
            // 
            this.tbActivity.Controls.Add(this.dtActivity);
            this.tbActivity.Location = new System.Drawing.Point(4, 25);
            this.tbActivity.Name = "tbActivity";
            this.tbActivity.Padding = new System.Windows.Forms.Padding(3);
            this.tbActivity.Size = new System.Drawing.Size(728, 337);
            this.tbActivity.TabIndex = 8;
            this.tbActivity.Text = "Activities";
            this.tbActivity.UseVisualStyleBackColor = true;
            // 
            // dtActivity
            // 
            this.dtActivity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtActivity.Location = new System.Drawing.Point(2, 3);
            this.dtActivity.Name = "dtActivity";
            this.dtActivity.RowTemplate.Height = 24;
            this.dtActivity.Size = new System.Drawing.Size(725, 334);
            this.dtActivity.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 472);
            this.Controls.Add(this.tb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.WorkOrderList);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Work Orders Interface";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tb.ResumeLayout(false);
            this.tbInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtInfo)).EndInit();
            this.tbComments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtComments)).EndInit();
            this.tbBookedHours.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtBookedHours)).EndInit();
            this.tbDocuments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtDocuments)).EndInit();
            this.tbMaterials.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtMaterials)).EndInit();
            this.tbLogs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtLogs)).EndInit();
            this.tbControlLists.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtControlLists)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkOrderList)).EndInit();
            this.tbActivity.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtActivity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tb;
        private System.Windows.Forms.TabPage tbInfo;
        private System.Windows.Forms.DataGridView dtInfo;
        private System.Windows.Forms.TabPage tbComments;
        private System.Windows.Forms.DataGridView dtComments;
        private System.Windows.Forms.TabPage tbBookedHours;
        private System.Windows.Forms.DataGridView dtBookedHours;
        private System.Windows.Forms.TabPage tbDocuments;
        private System.Windows.Forms.DataGridView dtDocuments;
        private System.Windows.Forms.TabPage tbMaterials;
        private System.Windows.Forms.DataGridView dtMaterials;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataGridView WorkOrderList;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tbLogs;
        private System.Windows.Forms.DataGridView dtLogs;
        private System.Windows.Forms.TabPage tbControlLists;
        private System.Windows.Forms.DataGridView dtControlLists;
        private System.Windows.Forms.TabPage tbActivity;
        private System.Windows.Forms.DataGridView dtActivity;
    }
}

