namespace Cirilizator
{
    partial class Ribbon1 : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Ribbon1()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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
            this.tab1 = this.Factory.CreateRibbonTab();
            this.Ćirilizator = this.Factory.CreateRibbonGroup();
            this.btnSekvencijalno = this.Factory.CreateRibbonButton();
            this.btnParalelno = this.Factory.CreateRibbonButton();
            this.btnAutomatski = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.Ćirilizator.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.Ćirilizator);
            this.tab1.Label = "TabAddIns";
            this.tab1.Name = "tab1";
            // 
            // Ćirilizator
            // 
            this.Ćirilizator.Items.Add(this.btnSekvencijalno);
            this.Ćirilizator.Items.Add(this.btnParalelno);
            this.Ćirilizator.Items.Add(this.btnAutomatski);
            this.Ćirilizator.Label = "Konverzija";
            this.Ćirilizator.Name = "Ćirilizator";
            // 
            // btnSekvencijalno
            // 
            this.btnSekvencijalno.Label = "Sekvencijalna konverzija";
            this.btnSekvencijalno.Name = "btnSekvencijalno";
            this.btnSekvencijalno.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnSekvencijalno_Click);
            // 
            // btnParalelno
            // 
            this.btnParalelno.Label = "Paralelna konverzija";
            this.btnParalelno.Name = "btnParalelno";
            this.btnParalelno.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnParalelno_Click);
            // 
            // btnAutomatski
            // 
            this.btnAutomatski.Label = "Automatska konverzija";
            this.btnAutomatski.Name = "btnAutomatski";
            this.btnAutomatski.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnAutomatski_Click);
            // 
            // Ribbon1
            // 
            this.Name = "Ribbon1";
            this.RibbonType = "Microsoft.Word.Document";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.Ćirilizator.ResumeLayout(false);
            this.Ćirilizator.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup Ćirilizator;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnSekvencijalno;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnParalelno;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnAutomatski;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon1 Ribbon1
        {
            get { return this.GetRibbon<Ribbon1>(); }
        }
    }
}
