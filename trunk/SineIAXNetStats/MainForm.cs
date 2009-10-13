/*
 * SineApps Custom Software
 * (C) 2005 SineApps LTD
 * Date: 13/08/2005
 * Time: 10:39 p.m.
 *
 * Please contact support@sineapps.com for more information
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SineIAXNetStats
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public class MainForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox remoteLossCount;
		private System.Windows.Forms.TextBox remoteJitter;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.TextBox LocalDelay;
		private System.Windows.Forms.TextBox RemoteDelay;
		private System.Windows.Forms.TextBox LocalOutOfOrder;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox localLossPercent;
		private System.Windows.Forms.TextBox remoteLossPercent;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox LocalDropped;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label returnTripTime;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox RemoteOutOfOrder;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox RemoteDropped;
		private System.Windows.Forms.TextBox RemotePackets;
		private System.Windows.Forms.TextBox localJitter;
		private System.Timers.Timer timer2;
		private System.Windows.Forms.TextBox LocalPackets;
		private System.Timers.Timer timer1;
		private System.Windows.Forms.TextBox localLossCount;
		int offsetX=230;
		int offsetY=20;
		static int sizeX=250;
		static int sizeY=250;
		Random rand=new Random();
		int[][] vals=new int[15][];
		
		[DllImport("netstats.dll")]
		public static extern int main2();
		[DllImport("netstats.dll")]
		public static extern int getRemoteJitter();
		[DllImport("netstats.dll")]
		public static extern int getRemoteLossPercent();
		[DllImport("netstats.dll")]
		public static extern int getRemoteLossCount();
		[DllImport("netstats.dll")]
		public static extern int getRemotePackets();
		[DllImport("netstats.dll")]
		public static extern int getRemoteDelay();
		[DllImport("netstats.dll")]
		public static extern int getRemoteDropped();
		[DllImport("netstats.dll")]
		public static extern int getRemoteOutOfOrder();
		[DllImport("netstats.dll")]
		
		public static extern int getLocalJitter();
		[DllImport("netstats.dll")]
		public static extern int getLocalLossPercent();
		[DllImport("netstats.dll")]
		public static extern int getLocalLossCount();
		[DllImport("netstats.dll")]
		public static extern int getLocalPackets();
		[DllImport("netstats.dll")]
		public static extern int getLocalDelay();
		[DllImport("netstats.dll")]
		public static extern int getLocalDropped();
		[DllImport("netstats.dll")]
		public static extern int getLocalOutOfOrder();
		[DllImport("netstats.dll")]
		public static extern int iaxc_call(string number);
		[DllImport("netstats.dll")]
		public static extern int iaxc_dump_all_calls();
		[DllImport("netstats.dll")]
		public static extern void quit();
		[DllImport("netstats.dll")]
		public static extern int getReturnTripTime();
		public MainForm()
		{
			
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			int x=main2();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
			for (int ii=0;ii<15;ii++){
				vals[ii]=new int[sizeX+1];
			for(int i=0;i<sizeX+1;i++){
					vals[ii][i]=0;;
			}
			}
			
		}
		
		[STAThread]
		public static void Main(string[] args)
		{
			Application.Run(new MainForm());
		}
		
		#region Windows Forms Designer generated code
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent() {
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(MainForm));
			this.localLossCount = new System.Windows.Forms.TextBox();
			this.timer1 = new System.Timers.Timer();
			this.LocalPackets = new System.Windows.Forms.TextBox();
			this.timer2 = new System.Timers.Timer();
			this.localJitter = new System.Windows.Forms.TextBox();
			this.RemotePackets = new System.Windows.Forms.TextBox();
			this.RemoteDropped = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.RemoteOutOfOrder = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.returnTripTime = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.LocalDropped = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.remoteLossPercent = new System.Windows.Forms.TextBox();
			this.localLossPercent = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.LocalOutOfOrder = new System.Windows.Forms.TextBox();
			this.RemoteDelay = new System.Windows.Forms.TextBox();
			this.LocalDelay = new System.Windows.Forms.TextBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.remoteJitter = new System.Windows.Forms.TextBox();
			this.remoteLossCount = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.timer1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.timer2)).BeginInit();
			this.SuspendLayout();
			// 
			// localLossCount
			// 
			this.localLossCount.Location = new System.Drawing.Point(88, 80);
			this.localLossCount.Name = "localLossCount";
			this.localLossCount.Size = new System.Drawing.Size(48, 21);
			this.localLossCount.TabIndex = 10;
			this.localLossCount.Text = "0";
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 1000;
			this.timer1.SynchronizingObject = this;
			this.timer1.Elapsed += new System.Timers.ElapsedEventHandler(this.Timer1Elapsed);
			// 
			// LocalPackets
			// 
			this.LocalPackets.Location = new System.Drawing.Point(88, 104);
			this.LocalPackets.Name = "LocalPackets";
			this.LocalPackets.Size = new System.Drawing.Size(48, 21);
			this.LocalPackets.TabIndex = 23;
			this.LocalPackets.Text = "0";
			// 
			// timer2
			// 
			this.timer2.Interval = 1000;
			this.timer2.SynchronizingObject = this;
			this.timer2.Elapsed += new System.Timers.ElapsedEventHandler(this.Timer2Elapsed);
			// 
			// localJitter
			// 
			this.localJitter.Location = new System.Drawing.Point(88, 32);
			this.localJitter.Name = "localJitter";
			this.localJitter.Size = new System.Drawing.Size(48, 21);
			this.localJitter.TabIndex = 4;
			this.localJitter.Text = "0";
			// 
			// RemotePackets
			// 
			this.RemotePackets.Location = new System.Drawing.Point(152, 104);
			this.RemotePackets.Name = "RemotePackets";
			this.RemotePackets.Size = new System.Drawing.Size(48, 21);
			this.RemotePackets.TabIndex = 24;
			this.RemotePackets.Text = "0";
			// 
			// RemoteDropped
			// 
			this.RemoteDropped.Location = new System.Drawing.Point(152, 152);
			this.RemoteDropped.Name = "RemoteDropped";
			this.RemoteDropped.Size = new System.Drawing.Size(48, 21);
			this.RemoteDropped.TabIndex = 18;
			this.RemoteDropped.Text = "0";
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Location = new System.Drawing.Point(8, 152);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(48, 23);
			this.label7.TabIndex = 16;
			this.label7.Text = "Dropped";
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.Color.Transparent;
			this.label11.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
			this.label11.Location = new System.Drawing.Point(488, 256);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(56, 23);
			this.label11.TabIndex = 28;
			this.label11.Text = "0";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(8, 248);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(192, 21);
			this.textBox1.TabIndex = 31;
			this.textBox1.Text = "user:pass@host/extension@context";
			// 
			// label14
			// 
			this.label14.BackColor = System.Drawing.Color.Transparent;
			this.label14.Location = new System.Drawing.Point(8, 208);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(104, 23);
			this.label14.TabIndex = 33;
			this.label14.Text = "Return Trip Time:";
			// 
			// RemoteOutOfOrder
			// 
			this.RemoteOutOfOrder.Location = new System.Drawing.Point(152, 176);
			this.RemoteOutOfOrder.Name = "RemoteOutOfOrder";
			this.RemoteOutOfOrder.Size = new System.Drawing.Size(48, 21);
			this.RemoteOutOfOrder.TabIndex = 21;
			this.RemoteOutOfOrder.Text = "0";
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.Transparent;
			this.label10.Location = new System.Drawing.Point(304, 120);
			this.label10.Name = "label10";
			this.label10.TabIndex = 25;
			this.label10.Text = "label10";
			this.label10.Visible = false;
			// 
			// label13
			// 
			this.label13.BackColor = System.Drawing.Color.Transparent;
			this.label13.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
			this.label13.Location = new System.Drawing.Point(488, 16);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(56, 23);
			this.label13.TabIndex = 32;
			this.label13.Text = "1";
			this.label13.Click += new System.EventHandler(this.ReturnTripTimeClick);
			// 
			// label12
			// 
			this.label12.BackColor = System.Drawing.Color.Transparent;
			this.label12.Location = new System.Drawing.Point(72, 224);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(88, 23);
			this.label12.TabIndex = 30;
			this.label12.Text = "IAX Dial String";
			// 
			// returnTripTime
			// 
			this.returnTripTime.BackColor = System.Drawing.Color.Transparent;
			this.returnTripTime.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
			this.returnTripTime.Location = new System.Drawing.Point(128, 200);
			this.returnTripTime.Name = "returnTripTime";
			this.returnTripTime.Size = new System.Drawing.Size(56, 23);
			this.returnTripTime.TabIndex = 12;
			this.returnTripTime.Click += new System.EventHandler(this.ReturnTripTimeClick);
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Location = new System.Drawing.Point(8, 128);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(40, 23);
			this.label8.TabIndex = 13;
			this.label8.Text = "Delay";
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.Location = new System.Drawing.Point(8, 80);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(64, 23);
			this.label9.TabIndex = 22;
			this.label9.Text = "Loss Count";
			// 
			// LocalDropped
			// 
			this.LocalDropped.Location = new System.Drawing.Point(88, 152);
			this.LocalDropped.Name = "LocalDropped";
			this.LocalDropped.Size = new System.Drawing.Size(48, 21);
			this.LocalDropped.TabIndex = 17;
			this.LocalDropped.Text = "0";
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Location = new System.Drawing.Point(8, 56);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(48, 23);
			this.label4.TabIndex = 6;
			this.label4.Text = "Loss %";
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Location = new System.Drawing.Point(8, 104);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(64, 23);
			this.label5.TabIndex = 9;
			this.label5.Text = "Packets";
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Location = new System.Drawing.Point(8, 176);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(72, 23);
			this.label6.TabIndex = 19;
			this.label6.Text = "Out of Order";
			// 
			// remoteLossPercent
			// 
			this.remoteLossPercent.Location = new System.Drawing.Point(152, 56);
			this.remoteLossPercent.Name = "remoteLossPercent";
			this.remoteLossPercent.Size = new System.Drawing.Size(48, 21);
			this.remoteLossPercent.TabIndex = 8;
			this.remoteLossPercent.Text = "0";
			// 
			// localLossPercent
			// 
			this.localLossPercent.Location = new System.Drawing.Point(88, 56);
			this.localLossPercent.Name = "localLossPercent";
			this.localLossPercent.Size = new System.Drawing.Size(48, 21);
			this.localLossPercent.TabIndex = 7;
			this.localLossPercent.Text = "0";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(88, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 16);
			this.label1.TabIndex = 1;
			this.label1.Text = "Local";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(144, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = "Remote";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(8, 32);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(40, 23);
			this.label3.TabIndex = 3;
			this.label3.Text = "Jitter";
			// 
			// LocalOutOfOrder
			// 
			this.LocalOutOfOrder.Location = new System.Drawing.Point(88, 176);
			this.LocalOutOfOrder.Name = "LocalOutOfOrder";
			this.LocalOutOfOrder.Size = new System.Drawing.Size(48, 21);
			this.LocalOutOfOrder.TabIndex = 20;
			this.LocalOutOfOrder.Text = "0";
			// 
			// RemoteDelay
			// 
			this.RemoteDelay.Location = new System.Drawing.Point(152, 128);
			this.RemoteDelay.Name = "RemoteDelay";
			this.RemoteDelay.Size = new System.Drawing.Size(48, 21);
			this.RemoteDelay.TabIndex = 15;
			this.RemoteDelay.Text = "0";
			// 
			// LocalDelay
			// 
			this.LocalDelay.Location = new System.Drawing.Point(88, 128);
			this.LocalDelay.Name = "LocalDelay";
			this.LocalDelay.Size = new System.Drawing.Size(48, 21);
			this.LocalDelay.TabIndex = 14;
			this.LocalDelay.Text = "0";
			// 
			// comboBox1
			// 
			this.comboBox1.Items.AddRange(new object[] {
						"Return Trip Time",
						"Remote Jitter",
						"Remote Loss Percent",
						"Remote Loss Count",
						"Remote Packets",
						"Remote Delay",
						"Remote Dropped",
						"Remote Out of Order",
						"Local Jitter",
						"Local Loss Percent",
						"Local Loss Count",
						"Local Packets",
						"Local Delay",
						"Local Dropped",
						"Local Out of Order"});
			this.comboBox1.Location = new System.Drawing.Point(216, 280);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(272, 21);
			this.comboBox1.TabIndex = 27;
			this.comboBox1.Text = "Return Trip Time";
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1SelectedIndexChanged);
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button1.Location = new System.Drawing.Point(136, 280);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(64, 24);
			this.button1.TabIndex = 0;
			this.button1.Text = "quit";
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button2.Location = new System.Drawing.Point(8, 280);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(64, 23);
			this.button2.TabIndex = 26;
			this.button2.Text = "Call";
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button3
			// 
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button3.Location = new System.Drawing.Point(72, 280);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(64, 23);
			this.button3.TabIndex = 29;
			this.button3.Text = "HangUp";
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// remoteJitter
			// 
			this.remoteJitter.Location = new System.Drawing.Point(152, 32);
			this.remoteJitter.Name = "remoteJitter";
			this.remoteJitter.Size = new System.Drawing.Size(48, 21);
			this.remoteJitter.TabIndex = 5;
			this.remoteJitter.Text = "0";
			// 
			// remoteLossCount
			// 
			this.remoteLossCount.Location = new System.Drawing.Point(152, 80);
			this.remoteLossCount.Name = "remoteLossCount";
			this.remoteLossCount.Size = new System.Drawing.Size(48, 21);
			this.remoteLossCount.TabIndex = 11;
			this.remoteLossCount.Text = "0";
			// 
			// MainForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(536, 318);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.RemotePackets);
			this.Controls.Add(this.LocalPackets);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.RemoteOutOfOrder);
			this.Controls.Add(this.LocalOutOfOrder);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.RemoteDropped);
			this.Controls.Add(this.LocalDropped);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.RemoteDelay);
			this.Controls.Add(this.LocalDelay);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.returnTripTime);
			this.Controls.Add(this.remoteLossCount);
			this.Controls.Add(this.localLossCount);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.remoteLossPercent);
			this.Controls.Add(this.localLossPercent);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.remoteJitter);
			this.Controls.Add(this.localJitter);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label14);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SineStatIAX";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.timer1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.timer2)).EndInit();
			this.ResumeLayout(false);
		}
		#endregion
		void Button1Click(object sender, System.EventArgs e)
		{
			quit();
		}
		
		void Timer1Elapsed(object sender, System.Timers.ElapsedEventArgs e)
		{
			localJitter.Text=""+getLocalJitter();
			remoteJitter.Text=""+getRemoteJitter();
			localLossPercent.Text=""+getLocalLossPercent();
			remoteLossPercent.Text=""+getRemoteLossPercent();
			localLossCount.Text=""+getLocalLossCount();
			remoteLossCount.Text=""+getRemoteLossCount();
			LocalPackets.Text=""+getLocalPackets();
			RemotePackets.Text=""+getRemotePackets();
			LocalDelay.Text=""+getLocalDelay();
			RemoteDelay.Text=""+getRemoteDelay();
			LocalDropped.Text=""+getLocalDropped();
			RemoteDropped.Text=""+getRemoteDropped();
			LocalOutOfOrder.Text=""+getLocalOutOfOrder();
			RemoteOutOfOrder.Text=""+getRemoteOutOfOrder();
			
			
			
			returnTripTime.Text=""+getReturnTripTime();
		}
		
		void Timer2Elapsed(object sender, System.Timers.ElapsedEventArgs e)
		{
			for (int ii=0;ii<15;ii++){
			for(int i=0;i<sizeX;i++){
					vals[ii][i]=vals[ii][i+1];;
				
			}
				
			}
			vals[0][sizeX]=getReturnTripTime();
			vals[1][sizeX]=getLocalJitter();
			vals[2][sizeX]=getRemoteJitter();
			vals[3][sizeX]=getLocalLossPercent();
			vals[4][sizeX]=getRemoteLossPercent();
			vals[5][sizeX]=getLocalLossCount();
			vals[6][sizeX]=getRemoteLossCount();
			vals[7][sizeX]=getLocalPackets();
			vals[8][sizeX]=getRemotePackets();
			vals[9][sizeX]=getLocalDelay();
			vals[10][sizeX]=getRemoteDelay();
			vals[11][sizeX]=getLocalDropped();
			vals[12][sizeX]=getRemoteDropped();
			vals[13][sizeX]=getLocalOutOfOrder();
			vals[14][sizeX]=getRemoteOutOfOrder();
			
			
			switch(comboBox1.SelectedIndex){
				case 0:
					drawGraph(vals[0]);
					break;
				case 1:
					drawGraph(vals[2]);
					break;
					
				case 2:
					drawGraph(vals[4]);
					break;
				case 3:
					drawGraph(vals[6]);
					break;
				case 4:
					drawGraph(vals[8]);
					break;
				case 5:
					drawGraph(vals[10]);
					break;
				case 6:
					drawGraph(vals[12]);
					break;
				case 7:
					drawGraph(vals[14]);
					break;
				case 8:
					drawGraph(vals[1]);
					break;
					
				case 9:
					drawGraph(vals[3]);
					break;
				case 10:
					drawGraph(vals[5]);
					break;
				case 11:
					drawGraph(vals[7]);
					break;
				case 12:
					drawGraph(vals[9]);
					break;
				case 13:
					drawGraph(vals[11]);
					break;
				case 14:
					drawGraph(vals[13]);
					break;
					
			}
			
		}
		void drawGraph(int[] inputArray){
			int maxvalue=0;
			
			//if (vals[sizeX>2
			Bitmap offScreenBmp;
			Graphics offScreenDC;
			
			Pen myPen=new Pen(Color.White);
			double multiplyer=0.0;
			offScreenBmp = new Bitmap(this.Width, this.Height);
			offScreenDC = Graphics.FromImage(offScreenBmp);
			//int iii=0;
			for (int iii=0;iii<sizeY+1;iii++){
				if (inputArray[iii]>maxvalue){
					maxvalue=inputArray[iii];
					
					multiplyer=(double)sizeY/(double)maxvalue;
					label13.Text=""+maxvalue;
				}
			}
			for (int x=offsetX;x<offsetX+sizeX-1;x++){
				offScreenDC.DrawLine(myPen,x,20,x,sizeY+offsetY);
				
			}
			int ii=0;
			for (int x=offsetX;x<offsetX+sizeX-1;x++){
				ii++;
				
				//if (vals[ii]/4<sizeY){
				//offScreenDC.DrawLine(new Pen(Color.FromArgb(vals[ii]/4+50,vals[ii]/4,vals[ii]/4)),x,(sizeY+offsetY)-vals[ii]/4,x,sizeY+offsetY);
				int newval=(int)((double)inputArray[ii]*multiplyer);
				int newval2=(int)((double)inputArray[ii+1]*multiplyer);
				offScreenDC.DrawLine(new Pen(Color.FromArgb((int)((double)newval/2),(int)((double)newval/2),newval)),x,((sizeY+offsetY)),x,((sizeY+offsetY)-newval2));
				
				//} else {
				//	offScreenDC.DrawLine(new Pen(Color.FromArgb(255,0,0)),x,(offsetY),x,sizeY+offsetY);
				
				//}
			}
			
			Graphics clientDC = this.CreateGraphics();
			// do drawing in offScreenDC
			// do drawing in offScreenDC
			// do drawing in offScreenDC
			clientDC.DrawImage(offScreenBmp, 0, 0);
			
		}
		void MainFormLoad(object sender, System.EventArgs e)
		{
			timer2.Enabled=true;
		}
		
		void Button2Click(object sender, System.EventArgs e)
		{
			iaxc_call(textBox1.Text);
		}
		
		void Button3Click(object sender, System.EventArgs e)
		{
			iaxc_dump_all_calls();
		}
		
		void ComboBox1SelectedIndexChanged(object sender, System.EventArgs e)
		{
			//for (int i=0;i<vals.Length;i++){
			//	vals[i]=0;
			//}
		}
		
		void ReturnTripTimeClick(object sender, System.EventArgs e)
		{
			
		}
		
	}
}
