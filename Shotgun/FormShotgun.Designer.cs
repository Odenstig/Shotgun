namespace Shotgun
{
    partial class FormShotgun
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
            this.buttonBlock = new System.Windows.Forms.Button();
            this.buttonReload = new System.Windows.Forms.Button();
            this.buttonShoot = new System.Windows.Forms.Button();
            this.buttonShotgun = new System.Windows.Forms.Button();
            this.labelPlayerAmmo = new System.Windows.Forms.Label();
            this.labelCPUAmmo = new System.Windows.Forms.Label();
            this.labelCPUAmmoCount = new System.Windows.Forms.Label();
            this.labelPlayerAmmoCount = new System.Windows.Forms.Label();
            this.labelShotgunGame = new System.Windows.Forms.Label();
            this.listBoxActions = new System.Windows.Forms.ListBox();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBlock
            // 
            this.buttonBlock.Location = new System.Drawing.Point(327, 341);
            this.buttonBlock.Margin = new System.Windows.Forms.Padding(40, 3, 40, 3);
            this.buttonBlock.Name = "buttonBlock";
            this.buttonBlock.Size = new System.Drawing.Size(133, 38);
            this.buttonBlock.TabIndex = 0;
            this.buttonBlock.TabStop = false;
            this.buttonBlock.Text = "Block";
            this.buttonBlock.UseVisualStyleBackColor = true;
            this.buttonBlock.Click += new System.EventHandler(this.ClickBlock);
            // 
            // buttonReload
            // 
            this.buttonReload.Location = new System.Drawing.Point(49, 341);
            this.buttonReload.Margin = new System.Windows.Forms.Padding(40, 3, 40, 3);
            this.buttonReload.Name = "buttonReload";
            this.buttonReload.Size = new System.Drawing.Size(133, 38);
            this.buttonReload.TabIndex = 2;
            this.buttonReload.TabStop = false;
            this.buttonReload.Text = "Reload";
            this.buttonReload.UseVisualStyleBackColor = true;
            this.buttonReload.Click += new System.EventHandler(this.ClickReload);
            // 
            // buttonShoot
            // 
            this.buttonShoot.Location = new System.Drawing.Point(188, 341);
            this.buttonShoot.Margin = new System.Windows.Forms.Padding(40, 3, 40, 3);
            this.buttonShoot.Name = "buttonShoot";
            this.buttonShoot.Size = new System.Drawing.Size(133, 38);
            this.buttonShoot.TabIndex = 3;
            this.buttonShoot.TabStop = false;
            this.buttonShoot.Text = "Shoot";
            this.buttonShoot.UseVisualStyleBackColor = true;
            this.buttonShoot.Click += new System.EventHandler(this.ClickShoot);
            // 
            // buttonShotgun
            // 
            this.buttonShotgun.Location = new System.Drawing.Point(188, 341);
            this.buttonShotgun.Margin = new System.Windows.Forms.Padding(40, 3, 40, 3);
            this.buttonShotgun.Name = "buttonShotgun";
            this.buttonShotgun.Size = new System.Drawing.Size(133, 38);
            this.buttonShotgun.TabIndex = 4;
            this.buttonShotgun.Text = "Shotgun!";
            this.buttonShotgun.UseVisualStyleBackColor = true;
            this.buttonShotgun.Visible = false;
            this.buttonShotgun.Click += new System.EventHandler(this.ClickShotgun);
            // 
            // labelPlayerAmmo
            // 
            this.labelPlayerAmmo.AutoSize = true;
            this.labelPlayerAmmo.Location = new System.Drawing.Point(77, 385);
            this.labelPlayerAmmo.Name = "labelPlayerAmmo";
            this.labelPlayerAmmo.Size = new System.Drawing.Size(68, 13);
            this.labelPlayerAmmo.TabIndex = 5;
            this.labelPlayerAmmo.Text = "Player Ammo";
            // 
            // labelCPUAmmo
            // 
            this.labelCPUAmmo.AutoSize = true;
            this.labelCPUAmmo.Location = new System.Drawing.Point(364, 385);
            this.labelCPUAmmo.Name = "labelCPUAmmo";
            this.labelCPUAmmo.Size = new System.Drawing.Size(61, 13);
            this.labelCPUAmmo.TabIndex = 6;
            this.labelCPUAmmo.Text = "CPU Ammo";
            // 
            // labelCPUAmmoCount
            // 
            this.labelCPUAmmoCount.AutoSize = true;
            this.labelCPUAmmoCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCPUAmmoCount.Location = new System.Drawing.Point(364, 403);
            this.labelCPUAmmoCount.Name = "labelCPUAmmoCount";
            this.labelCPUAmmoCount.Size = new System.Drawing.Size(18, 20);
            this.labelCPUAmmoCount.TabIndex = 7;
            this.labelCPUAmmoCount.Text = "0";
            // 
            // labelPlayerAmmoCount
            // 
            this.labelPlayerAmmoCount.AutoSize = true;
            this.labelPlayerAmmoCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayerAmmoCount.Location = new System.Drawing.Point(127, 403);
            this.labelPlayerAmmoCount.Name = "labelPlayerAmmoCount";
            this.labelPlayerAmmoCount.Size = new System.Drawing.Size(18, 20);
            this.labelPlayerAmmoCount.TabIndex = 8;
            this.labelPlayerAmmoCount.Text = "0";
            // 
            // labelShotgunGame
            // 
            this.labelShotgunGame.AutoSize = true;
            this.labelShotgunGame.Font = new System.Drawing.Font("Rosewood Std Regular", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShotgunGame.Location = new System.Drawing.Point(109, 20);
            this.labelShotgunGame.Name = "labelShotgunGame";
            this.labelShotgunGame.Size = new System.Drawing.Size(290, 75);
            this.labelShotgunGame.TabIndex = 9;
            this.labelShotgunGame.Text = "Shotgun";
            // 
            // listBoxActions
            // 
            this.listBoxActions.FormattingEnabled = true;
            this.listBoxActions.Location = new System.Drawing.Point(49, 97);
            this.listBoxActions.Name = "listBoxActions";
            this.listBoxActions.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxActions.Size = new System.Drawing.Size(411, 238);
            this.listBoxActions.TabIndex = 10;
            this.listBoxActions.TabStop = false;
            // 
            // buttonRestart
            // 
            this.buttonRestart.Location = new System.Drawing.Point(188, 385);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(133, 38);
            this.buttonRestart.TabIndex = 11;
            this.buttonRestart.Text = "Restart?";
            this.buttonRestart.UseVisualStyleBackColor = true;
            this.buttonRestart.Visible = false;
            this.buttonRestart.Click += new System.EventHandler(this.ClickRestart);
            // 
            // FormShotgun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 450);
            this.Controls.Add(this.buttonRestart);
            this.Controls.Add(this.listBoxActions);
            this.Controls.Add(this.labelShotgunGame);
            this.Controls.Add(this.labelPlayerAmmoCount);
            this.Controls.Add(this.labelCPUAmmoCount);
            this.Controls.Add(this.labelCPUAmmo);
            this.Controls.Add(this.labelPlayerAmmo);
            this.Controls.Add(this.buttonShotgun);
            this.Controls.Add(this.buttonShoot);
            this.Controls.Add(this.buttonReload);
            this.Controls.Add(this.buttonBlock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormShotgun";
            this.Text = "Shotgun";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBlock;
        private System.Windows.Forms.Button buttonReload;
        private System.Windows.Forms.Button buttonShoot;
        private System.Windows.Forms.Button buttonShotgun;
        private System.Windows.Forms.Label labelPlayerAmmo;
        private System.Windows.Forms.Label labelCPUAmmo;
        private System.Windows.Forms.Label labelCPUAmmoCount;
        private System.Windows.Forms.Label labelPlayerAmmoCount;
        private System.Windows.Forms.Label labelShotgunGame;
        private System.Windows.Forms.ListBox listBoxActions;
        private System.Windows.Forms.Button buttonRestart;
    }
}

