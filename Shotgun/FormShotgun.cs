using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shotgun.Classes;

namespace Shotgun
{
    public partial class FormShotgun : Form
    {
        private readonly CPU cpu = new CPU();
        private readonly Player player = new Player();
        private readonly GameLogic gameLogic = new GameLogic();
        private readonly BulletManager bulletManager = new BulletManager();

        public FormShotgun()
        {
            InitializeComponent();
        }

        private void ClickReload(object sender, EventArgs e)
        {
            listBoxActions.Items.Add(player.Reload() + " and " + cpu.Random() + ".");
            listBoxActions.Items.Add(gameLogic.Scenarios());
            UpdateBullets();
            CheckGameOver();
        }

        private void ClickShoot(object sender, EventArgs e)
        {
            listBoxActions.Items.Add(player.Shoot() + " and " + cpu.Random() + ".");
            listBoxActions.Items.Add(gameLogic.Scenarios());
            UpdateBullets();
            CheckGameOver();
        }

        private void ClickBlock(object sender, EventArgs e)
        {
            listBoxActions.Items.Add(player.Block() + " and " + cpu.Random() + ".");
            listBoxActions.Items.Add(gameLogic.Scenarios());
            UpdateBullets();
            CheckGameOver();
        }

        private void ClickShotgun(object sender, EventArgs e)
        {
            listBoxActions.Items.Add(player.Shotgun() + " and " + cpu.Random() + ".");
            listBoxActions.Items.Add(gameLogic.Scenarios());
            UpdateBullets();
            CheckGameOver();
        }

        private void ClickRestart(object sender, EventArgs e)
        {
            listBoxActions.Items.Clear();
            bulletManager.ResetBullets();
            gameLogic.Reset();
            buttonBlock.Visible = true;
            buttonReload.Visible = true;
            buttonShoot.Visible = true;
            buttonRestart.Visible = false;
            UpdateBullets();
        }

        private void CheckGameOver()
        {
            if (gameLogic.CheckGameOver() == true)
            {
                buttonRestart.Visible = true;
                buttonBlock.Visible = false;
                buttonReload.Visible = false;
                buttonShoot.Visible = false;
                buttonShotgun.Visible = false;
            }
        }

        private void UpdateBullets()
        {
            labelPlayerAmmoCount.Text = bulletManager.PlayerBulletCount().ToString();
            labelCPUAmmoCount.Text = bulletManager.CPUBulletCount().ToString();

            if (bulletManager.PlayerBulletCount() >= 3)
                buttonShotgun.Visible = true;
            else
                buttonShotgun.Visible = false;
        }
    }
}
