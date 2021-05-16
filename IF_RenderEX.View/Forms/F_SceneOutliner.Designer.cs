
namespace IF_RenderEX.View.Forms
{
    partial class F_SceneOutliner
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
            this.tlp_SceneOutliner = new System.Windows.Forms.TableLayoutPanel();
            this.lvw_SceneObjects = new System.Windows.Forms.ListView();
            this.col_SceneObjects = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnl_SceneOutliner_MENU = new System.Windows.Forms.Panel();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_Locked = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tlp_SceneOutliner.SuspendLayout();
            this.pnl_SceneOutliner_MENU.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp_SceneOutliner
            // 
            this.tlp_SceneOutliner.ColumnCount = 1;
            this.tlp_SceneOutliner.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_SceneOutliner.Controls.Add(this.lvw_SceneObjects, 0, 0);
            this.tlp_SceneOutliner.Controls.Add(this.pnl_SceneOutliner_MENU, 0, 1);
            this.tlp_SceneOutliner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_SceneOutliner.Location = new System.Drawing.Point(0, 0);
            this.tlp_SceneOutliner.Name = "tlp_SceneOutliner";
            this.tlp_SceneOutliner.RowCount = 2;
            this.tlp_SceneOutliner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_SceneOutliner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_SceneOutliner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_SceneOutliner.Size = new System.Drawing.Size(284, 370);
            this.tlp_SceneOutliner.TabIndex = 0;
            // 
            // lvw_SceneObjects
            // 
            this.lvw_SceneObjects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(70)))), ((int)(((byte)(71)))));
            this.lvw_SceneObjects.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvw_SceneObjects.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_SceneObjects});
            this.lvw_SceneObjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvw_SceneObjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvw_SceneObjects.FullRowSelect = true;
            this.lvw_SceneObjects.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvw_SceneObjects.HideSelection = false;
            this.lvw_SceneObjects.Location = new System.Drawing.Point(0, 0);
            this.lvw_SceneObjects.Margin = new System.Windows.Forms.Padding(0);
            this.lvw_SceneObjects.Name = "lvw_SceneObjects";
            this.lvw_SceneObjects.Size = new System.Drawing.Size(284, 350);
            this.lvw_SceneObjects.TabIndex = 0;
            this.lvw_SceneObjects.UseCompatibleStateImageBehavior = false;
            this.lvw_SceneObjects.View = System.Windows.Forms.View.Details;
            // 
            // col_SceneObjects
            // 
            this.col_SceneObjects.Width = 284;
            // 
            // pnl_SceneOutliner_MENU
            // 
            this.pnl_SceneOutliner_MENU.Controls.Add(this.button3);
            this.pnl_SceneOutliner_MENU.Controls.Add(this.btn_Locked);
            this.pnl_SceneOutliner_MENU.Controls.Add(this.btn_Excluir);
            this.pnl_SceneOutliner_MENU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_SceneOutliner_MENU.Location = new System.Drawing.Point(0, 350);
            this.pnl_SceneOutliner_MENU.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_SceneOutliner_MENU.Name = "pnl_SceneOutliner_MENU";
            this.pnl_SceneOutliner_MENU.Size = new System.Drawing.Size(284, 20);
            this.pnl_SceneOutliner_MENU.TabIndex = 1;
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Excluir.BackColor = System.Drawing.Color.White;
            this.btn_Excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Excluir.Location = new System.Drawing.Point(259, 0);
            this.btn_Excluir.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(25, 20);
            this.btn_Excluir.TabIndex = 0;
            this.btn_Excluir.TabStop = false;
            this.btn_Excluir.Text = "E";
            this.btn_Excluir.UseVisualStyleBackColor = false;
            // 
            // btn_Locked
            // 
            this.btn_Locked.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Locked.BackColor = System.Drawing.Color.White;
            this.btn_Locked.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Locked.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Locked.Location = new System.Drawing.Point(234, 0);
            this.btn_Locked.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Locked.Name = "btn_Locked";
            this.btn_Locked.Size = new System.Drawing.Size(25, 20);
            this.btn_Locked.TabIndex = 1;
            this.btn_Locked.TabStop = false;
            this.btn_Locked.Text = "L";
            this.btn_Locked.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(209, 0);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(25, 20);
            this.button3.TabIndex = 2;
            this.button3.TabStop = false;
            this.button3.Text = "V";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // F_SceneOutliner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(70)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(284, 370);
            this.Controls.Add(this.tlp_SceneOutliner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_SceneOutliner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scene Outliner";
            this.tlp_SceneOutliner.ResumeLayout(false);
            this.pnl_SceneOutliner_MENU.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_SceneOutliner;
        private System.Windows.Forms.ListView lvw_SceneObjects;
        private System.Windows.Forms.ColumnHeader col_SceneObjects;
        private System.Windows.Forms.Panel pnl_SceneOutliner_MENU;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_Locked;
        private System.Windows.Forms.Button btn_Excluir;
    }
}