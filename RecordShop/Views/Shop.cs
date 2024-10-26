﻿using RecordShop.UserControllers;

namespace RecordShop.Views
{
	public partial class Shop : Form
	{
		enum SystemOption
		{
			Dashboard,
			Order,
			Vinyl,
			Seller,
			Buyer,
			OrderHistory,
			Setting
		}

		private Options Options;
		public static Shop? ShopInstant;

		public Shop()
		{
			InitializeComponent();
			Options = new Options();
			this.BtnDashboardOption.BackColor = SystemColors.ControlLight;
			Options.ShowUserControl<Dashboard>(this.FlowContainPanel, new Dashboard());
			this.BtnDashboardOption.Enabled = false;
		}

		private void SelectSystemOptions(SystemOption option)
		{
			this.BtnDashboardOption.BackColor = SystemColors.Window;
			this.BtnOrderOption.BackColor = SystemColors.Window;
			this.BtnVinylOption.BackColor = SystemColors.Window;
			this.BtnSellersOption.BackColor = SystemColors.Window;
			this.BtnBuyersOption.BackColor = SystemColors.Window;
			this.BtnOrderHistoryOption.BackColor = SystemColors.Window;
			this.BtnSettingsOption.BackColor = SystemColors.Window;
			this.orderNotificationCount.BackColor = SystemColors.Window;

			this.BtnDashboardOption.Enabled = true;
			this.BtnOrderOption.Enabled = true;
			this.BtnVinylOption.Enabled = true;
			this.BtnSellersOption.Enabled = true;
			this.BtnBuyersOption.Enabled = true;
			this.BtnOrderHistoryOption.Enabled = true;
			this.BtnSettingsOption.Enabled = true;

			this.FlowContainPanel.Controls.Clear();

			switch (option)
			{
				case SystemOption.Dashboard:
					{
						this.BtnDashboardOption.BackColor = SystemColors.ControlLight;
						Options.ShowUserControl<Dashboard>(this.FlowContainPanel, new Dashboard());
						this.BtnDashboardOption.Enabled = false;
						break;
					}
				case SystemOption.Order:
					{
						this.BtnOrderOption.Enabled = false;
						Options.ShowUserControl<Order>(this.FlowContainPanel, new Order());
						this.BtnOrderOption.BackColor = SystemColors.ControlLight;
						break;
					}
				case SystemOption.Vinyl:
					{
						this.BtnVinylOption.BackColor = SystemColors.ControlLight;
						Options.ShowUserControl<Vinyls>(this.FlowContainPanel, new Vinyls());
						this.BtnVinylOption.Enabled = false;
						break;
					}
				case SystemOption.Seller:
					{
						this.BtnSellersOption.BackColor = SystemColors.ControlLight;
						Options.ShowUserControl<Seller>(this.FlowContainPanel, new Seller());
						this.BtnSellersOption.Enabled = false;
						break;
					}
				case SystemOption.Buyer:
					{
						this.BtnBuyersOption.BackColor = SystemColors.ControlLight;
						Options.ShowUserControl<Buyer>(this.FlowContainPanel, new Buyer());
						this.BtnBuyersOption.Enabled = false;
						break;
					}
				case SystemOption.OrderHistory:
					{
						this.BtnOrderHistoryOption.BackColor = SystemColors.ControlLight;
						this.orderNotificationCount.BackColor = SystemColors.ControlLight;
						Options.ShowUserControl<OrderHistory>(this.FlowContainPanel, new OrderHistory());
						this.BtnOrderHistoryOption.Enabled = false;
						break;
					}
				case SystemOption.Setting:
					{
						this.BtnSettingsOption.BackColor = SystemColors.ControlLight;
						Options.ShowUserControl<Setting>(this.FlowContainPanel, new Setting());
						this.BtnSettingsOption.Enabled = false;
						break;
					}
			}
		}

		private void BtnDashboardOption_Click(object sender, EventArgs e) => SelectSystemOptions(SystemOption.Dashboard);

		private void BtnVinylOption_Click(object sender, EventArgs e) => SelectSystemOptions(SystemOption.Vinyl);

		private void BtnOrderOption_Click(object sender, EventArgs e) => SelectSystemOptions(SystemOption.Order);

		private void BtnSellersOption_Click(object sender, EventArgs e) => SelectSystemOptions(SystemOption.Seller);

		private void BtnBuyersOption_Click(object sender, EventArgs e) => SelectSystemOptions(SystemOption.Buyer);

		private void BtnSettingsOption_Click(object sender, EventArgs e) => SelectSystemOptions(SystemOption.Setting);

		private void BtnOrderHistoryOption_Click(object sender, EventArgs e) => SelectSystemOptions(SystemOption.OrderHistory);

		private void BtnOrderHistoryOption_MouseLeave(object sender, EventArgs e)
		{
			if(this.BtnOrderHistoryOption.Enabled == true)
			{
				this.orderNotificationCount.BackColor = SystemColors.Window;
				this.orderNotificationCount.FlatStyle = FlatStyle.Standard;
				this.orderNotificationCount.FlatAppearance.BorderSize = 1;
			}
		}

		private void BtnOrderHistoryOption_MouseClick(object sender, MouseEventArgs e)
		{
			this.orderNotificationCount.BackColor = SystemColors.ControlLight;
			this.orderNotificationCount.FlatStyle = FlatStyle.Flat;
			this.orderNotificationCount.FlatAppearance.BorderSize = 0;
			this.orderNotificationCount.Enabled = false;
		}
		private void BtnOrderHistoryOption_MouseHover(object sender, EventArgs e)
		{
			this.orderNotificationCount.BackColor = SystemColors.ControlLight;
			this.orderNotificationCount.FlatStyle = FlatStyle.Flat;
			this.orderNotificationCount.FlatAppearance.BorderSize = 0;
		}
	}


	// Class Control Instantiate User Controls

	public class Options
	{
		public void ShowUserControl<T>(FlowLayoutPanel panel, T t)
		{
			var control = t as UserControl;
			if (control is null)
			{
				control.BackColor = SystemColors.Window;
				control.Location = new Point(3, 3);
				control.Name = t.ToString().ToLower();
				control.Size = new Size(1600, 970);
				control.TabIndex = 0;
			}
			if (!panel.Controls.Contains(control))
			{
				panel.Controls.Add(control);
				control.BringToFront();
			}
			//control.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			control.Show();
			// MessageBox.Show(control.Name);
		}

		public void HideUserControl<T>(Panel panel, T t)
		{
			var control = t as UserControl;
			if (control != null)
				panel.Controls.Remove(control);
		}
	}
}