namespace Fit_Lanches
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.preco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tempo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listItem = new System.Windows.Forms.ListView();
            this.btnPrep = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblAtual = new System.Windows.Forms.Label();
            this.tmrProcess = new System.Windows.Forms.Timer(this.components);
            this.tmrHora = new System.Windows.Forms.Timer(this.components);
            this.grpPrepar1 = new System.Windows.Forms.GroupBox();
            this.lblPrepITem1 = new System.Windows.Forms.Label();
            this.lblPrepNome1 = new System.Windows.Forms.Label();
            this.lblCount1 = new System.Windows.Forms.Label();
            this.picPrep12 = new System.Windows.Forms.PictureBox();
            this.picPrep11 = new System.Windows.Forms.PictureBox();
            this.grpPrepar2 = new System.Windows.Forms.GroupBox();
            this.lblPrepITem2 = new System.Windows.Forms.Label();
            this.lblPrepNome2 = new System.Windows.Forms.Label();
            this.lblCount2 = new System.Windows.Forms.Label();
            this.picPrep22 = new System.Windows.Forms.PictureBox();
            this.picPrep21 = new System.Windows.Forms.PictureBox();
            this.listEspera = new System.Windows.Forms.ListView();
            this.nomeClient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tmpItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblEsp = new System.Windows.Forms.Label();
            this.tmrProcess2 = new System.Windows.Forms.Timer(this.components);
            this.lblNome = new System.Windows.Forms.Label();
            this.grpCozinha = new System.Windows.Forms.GroupBox();
            this.btnLoadCard = new System.Windows.Forms.Button();
            this.btnEntreg = new System.Windows.Forms.Button();
            this.listEntrega = new System.Windows.Forms.ListView();
            this.EntrNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EntrItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblListEntreg = new System.Windows.Forms.Label();
            this.grpPrepar1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPrep12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPrep11)).BeginInit();
            this.grpPrepar2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPrep22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPrep21)).BeginInit();
            this.grpCozinha.SuspendLayout();
            this.SuspendLayout();
            // 
            // nome
            // 
            this.nome.Text = "Lanche";
            this.nome.Width = 113;
            // 
            // preco
            // 
            this.preco.Text = "Preço";
            this.preco.Width = 97;
            // 
            // tempo
            // 
            this.tempo.Text = "Tempo (seg)";
            this.tempo.Width = 118;
            // 
            // listItem
            // 
            this.listItem.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nome,
            this.preco,
            this.tempo});
            this.listItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listItem.FullRowSelect = true;
            this.listItem.GridLines = true;
            this.listItem.Location = new System.Drawing.Point(24, 81);
            this.listItem.Name = "listItem";
            this.listItem.Size = new System.Drawing.Size(442, 226);
            this.listItem.TabIndex = 0;
            this.listItem.UseCompatibleStateImageBehavior = false;
            this.listItem.View = System.Windows.Forms.View.Details;
            this.listItem.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listItem_ItemSelectionChanged);
            // 
            // btnPrep
            // 
            this.btnPrep.Enabled = false;
            this.btnPrep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrep.Location = new System.Drawing.Point(27, 33);
            this.btnPrep.Name = "btnPrep";
            this.btnPrep.Size = new System.Drawing.Size(100, 42);
            this.btnPrep.TabIndex = 1;
            this.btnPrep.Text = "Preparar";
            this.btnPrep.UseVisualStyleBackColor = true;
            this.btnPrep.Click += new System.EventHandler(this.btnPrep_Click);
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(251, 40);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(171, 27);
            this.txtNome.TabIndex = 2;
            // 
            // lblAtual
            // 
            this.lblAtual.AutoSize = true;
            this.lblAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtual.Location = new System.Drawing.Point(515, 8);
            this.lblAtual.Name = "lblAtual";
            this.lblAtual.Size = new System.Drawing.Size(96, 17);
            this.lblAtual.TabIndex = 3;
            this.lblAtual.Text = "Hora e Data";
            // 
            // tmrProcess
            // 
            this.tmrProcess.Tick += new System.EventHandler(this.tmrProcess_Tick);
            // 
            // tmrHora
            // 
            this.tmrHora.Enabled = true;
            this.tmrHora.Tick += new System.EventHandler(this.tmrHora_Tick);
            // 
            // grpPrepar1
            // 
            this.grpPrepar1.Controls.Add(this.lblPrepITem1);
            this.grpPrepar1.Controls.Add(this.lblPrepNome1);
            this.grpPrepar1.Controls.Add(this.lblCount1);
            this.grpPrepar1.Controls.Add(this.picPrep12);
            this.grpPrepar1.Controls.Add(this.picPrep11);
            this.grpPrepar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPrepar1.Location = new System.Drawing.Point(33, 38);
            this.grpPrepar1.Name = "grpPrepar1";
            this.grpPrepar1.Size = new System.Drawing.Size(442, 163);
            this.grpPrepar1.TabIndex = 5;
            this.grpPrepar1.TabStop = false;
            this.grpPrepar1.Text = "Preparo 1";
            // 
            // lblPrepITem1
            // 
            this.lblPrepITem1.AutoSize = true;
            this.lblPrepITem1.Location = new System.Drawing.Point(18, 52);
            this.lblPrepITem1.Name = "lblPrepITem1";
            this.lblPrepITem1.Size = new System.Drawing.Size(45, 20);
            this.lblPrepITem1.TabIndex = 7;
            this.lblPrepITem1.Text = "Item";
            this.lblPrepITem1.Visible = false;
            // 
            // lblPrepNome1
            // 
            this.lblPrepNome1.AutoSize = true;
            this.lblPrepNome1.Location = new System.Drawing.Point(18, 86);
            this.lblPrepNome1.Name = "lblPrepNome1";
            this.lblPrepNome1.Size = new System.Drawing.Size(122, 20);
            this.lblPrepNome1.TabIndex = 4;
            this.lblPrepNome1.Text = "Nome Cliente";
            this.lblPrepNome1.Visible = false;
            // 
            // lblCount1
            // 
            this.lblCount1.AutoSize = true;
            this.lblCount1.Location = new System.Drawing.Point(251, 23);
            this.lblCount1.Name = "lblCount1";
            this.lblCount1.Size = new System.Drawing.Size(55, 20);
            this.lblCount1.TabIndex = 3;
            this.lblCount1.Text = "00:00";
            // 
            // picPrep12
            // 
            this.picPrep12.Image = ((System.Drawing.Image)(resources.GetObject("picPrep12.Image")));
            this.picPrep12.Location = new System.Drawing.Point(345, 98);
            this.picPrep12.Name = "picPrep12";
            this.picPrep12.Size = new System.Drawing.Size(70, 59);
            this.picPrep12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPrep12.TabIndex = 2;
            this.picPrep12.TabStop = false;
            this.picPrep12.Visible = false;
            // 
            // picPrep11
            // 
            this.picPrep11.Image = ((System.Drawing.Image)(resources.GetObject("picPrep11.Image")));
            this.picPrep11.Location = new System.Drawing.Point(256, 98);
            this.picPrep11.Name = "picPrep11";
            this.picPrep11.Size = new System.Drawing.Size(70, 59);
            this.picPrep11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPrep11.TabIndex = 1;
            this.picPrep11.TabStop = false;
            this.picPrep11.Visible = false;
            // 
            // grpPrepar2
            // 
            this.grpPrepar2.Controls.Add(this.lblPrepITem2);
            this.grpPrepar2.Controls.Add(this.lblPrepNome2);
            this.grpPrepar2.Controls.Add(this.lblCount2);
            this.grpPrepar2.Controls.Add(this.picPrep22);
            this.grpPrepar2.Controls.Add(this.picPrep21);
            this.grpPrepar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPrepar2.Location = new System.Drawing.Point(33, 207);
            this.grpPrepar2.Name = "grpPrepar2";
            this.grpPrepar2.Size = new System.Drawing.Size(442, 163);
            this.grpPrepar2.TabIndex = 6;
            this.grpPrepar2.TabStop = false;
            this.grpPrepar2.Text = "Preparo 2";
            // 
            // lblPrepITem2
            // 
            this.lblPrepITem2.AutoSize = true;
            this.lblPrepITem2.Location = new System.Drawing.Point(18, 51);
            this.lblPrepITem2.Name = "lblPrepITem2";
            this.lblPrepITem2.Size = new System.Drawing.Size(45, 20);
            this.lblPrepITem2.TabIndex = 6;
            this.lblPrepITem2.Text = "Item";
            this.lblPrepITem2.Visible = false;
            // 
            // lblPrepNome2
            // 
            this.lblPrepNome2.AutoSize = true;
            this.lblPrepNome2.Location = new System.Drawing.Point(18, 87);
            this.lblPrepNome2.Name = "lblPrepNome2";
            this.lblPrepNome2.Size = new System.Drawing.Size(122, 20);
            this.lblPrepNome2.TabIndex = 5;
            this.lblPrepNome2.Text = "Nome Cliente";
            this.lblPrepNome2.Visible = false;
            // 
            // lblCount2
            // 
            this.lblCount2.AutoSize = true;
            this.lblCount2.Location = new System.Drawing.Point(251, 23);
            this.lblCount2.Name = "lblCount2";
            this.lblCount2.Size = new System.Drawing.Size(55, 20);
            this.lblCount2.TabIndex = 4;
            this.lblCount2.Text = "00:00";
            // 
            // picPrep22
            // 
            this.picPrep22.Image = ((System.Drawing.Image)(resources.GetObject("picPrep22.Image")));
            this.picPrep22.Location = new System.Drawing.Point(345, 98);
            this.picPrep22.Name = "picPrep22";
            this.picPrep22.Size = new System.Drawing.Size(70, 59);
            this.picPrep22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPrep22.TabIndex = 2;
            this.picPrep22.TabStop = false;
            this.picPrep22.Visible = false;
            // 
            // picPrep21
            // 
            this.picPrep21.Image = ((System.Drawing.Image)(resources.GetObject("picPrep21.Image")));
            this.picPrep21.Location = new System.Drawing.Point(256, 98);
            this.picPrep21.Name = "picPrep21";
            this.picPrep21.Size = new System.Drawing.Size(70, 59);
            this.picPrep21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPrep21.TabIndex = 1;
            this.picPrep21.TabStop = false;
            this.picPrep21.Visible = false;
            // 
            // listEspera
            // 
            this.listEspera.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nomeClient,
            this.itemNome,
            this.tmpItem});
            this.listEspera.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listEspera.GridLines = true;
            this.listEspera.Location = new System.Drawing.Point(518, 81);
            this.listEspera.Name = "listEspera";
            this.listEspera.Size = new System.Drawing.Size(598, 226);
            this.listEspera.TabIndex = 9;
            this.listEspera.UseCompatibleStateImageBehavior = false;
            this.listEspera.View = System.Windows.Forms.View.Details;
            // 
            // nomeClient
            // 
            this.nomeClient.Text = "Cliente";
            this.nomeClient.Width = 158;
            // 
            // itemNome
            // 
            this.itemNome.Text = "Lanche";
            this.itemNome.Width = 169;
            // 
            // tmpItem
            // 
            this.tmpItem.Text = "Tempo (seg)";
            this.tmpItem.Width = 123;
            // 
            // lblEsp
            // 
            this.lblEsp.AutoSize = true;
            this.lblEsp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEsp.Location = new System.Drawing.Point(515, 50);
            this.lblEsp.Name = "lblEsp";
            this.lblEsp.Size = new System.Drawing.Size(142, 20);
            this.lblEsp.TabIndex = 10;
            this.lblEsp.Text = "Lista de Espera";
            // 
            // tmrProcess2
            // 
            this.tmrProcess2.Tick += new System.EventHandler(this.tmrProcess2_Tick);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(147, 46);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(98, 17);
            this.lblNome.TabIndex = 11;
            this.lblNome.Text = "Nome cliente: ";
            // 
            // grpCozinha
            // 
            this.grpCozinha.Controls.Add(this.grpPrepar1);
            this.grpCozinha.Controls.Add(this.grpPrepar2);
            this.grpCozinha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCozinha.Location = new System.Drawing.Point(167, 324);
            this.grpCozinha.Name = "grpCozinha";
            this.grpCozinha.Size = new System.Drawing.Size(490, 383);
            this.grpCozinha.TabIndex = 12;
            this.grpCozinha.TabStop = false;
            this.grpCozinha.Text = "Cozinha";
            // 
            // btnLoadCard
            // 
            this.btnLoadCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadCard.Location = new System.Drawing.Point(24, 324);
            this.btnLoadCard.Name = "btnLoadCard";
            this.btnLoadCard.Size = new System.Drawing.Size(120, 76);
            this.btnLoadCard.TabIndex = 0;
            this.btnLoadCard.Text = "Carregar Cardápio";
            this.btnLoadCard.UseVisualStyleBackColor = true;
            this.btnLoadCard.Click += new System.EventHandler(this.btnLoadCard_Click);
            // 
            // btnEntreg
            // 
            this.btnEntreg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntreg.Location = new System.Drawing.Point(1020, 362);
            this.btnEntreg.Name = "btnEntreg";
            this.btnEntreg.Size = new System.Drawing.Size(96, 54);
            this.btnEntreg.TabIndex = 14;
            this.btnEntreg.Text = "Entregar";
            this.btnEntreg.UseVisualStyleBackColor = true;
            this.btnEntreg.Click += new System.EventHandler(this.btnEntreg_Click);
            // 
            // listEntrega
            // 
            this.listEntrega.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.EntrNome,
            this.EntrItem});
            this.listEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listEntrega.FullRowSelect = true;
            this.listEntrega.GridLines = true;
            this.listEntrega.Location = new System.Drawing.Point(679, 362);
            this.listEntrega.Name = "listEntrega";
            this.listEntrega.Size = new System.Drawing.Size(305, 345);
            this.listEntrega.TabIndex = 15;
            this.listEntrega.UseCompatibleStateImageBehavior = false;
            this.listEntrega.View = System.Windows.Forms.View.Details;
            // 
            // EntrNome
            // 
            this.EntrNome.Text = "Cliente";
            this.EntrNome.Width = 126;
            // 
            // EntrItem
            // 
            this.EntrItem.Text = "Lanche";
            this.EntrItem.Width = 140;
            // 
            // lblListEntreg
            // 
            this.lblListEntreg.AutoSize = true;
            this.lblListEntreg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListEntreg.Location = new System.Drawing.Point(675, 324);
            this.lblListEntreg.Name = "lblListEntreg";
            this.lblListEntreg.Size = new System.Drawing.Size(148, 20);
            this.lblListEntreg.TabIndex = 16;
            this.lblListEntreg.Text = "Lista de Entrega";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 721);
            this.Controls.Add(this.lblListEntreg);
            this.Controls.Add(this.listEntrega);
            this.Controls.Add(this.btnEntreg);
            this.Controls.Add(this.btnLoadCard);
            this.Controls.Add(this.grpCozinha);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblEsp);
            this.Controls.Add(this.listEspera);
            this.Controls.Add(this.lblAtual);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnPrep);
            this.Controls.Add(this.listItem);
            this.Name = "frmPrincipal";
            this.Text = "FitLanches";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.grpPrepar1.ResumeLayout(false);
            this.grpPrepar1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPrep12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPrep11)).EndInit();
            this.grpPrepar2.ResumeLayout(false);
            this.grpPrepar2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPrep22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPrep21)).EndInit();
            this.grpCozinha.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader nome;
        private System.Windows.Forms.ColumnHeader preco;
        private System.Windows.Forms.ColumnHeader tempo;
        private System.Windows.Forms.ListView listItem;
        private System.Windows.Forms.Button btnPrep;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblAtual;
        private System.Windows.Forms.Timer tmrProcess;
        private System.Windows.Forms.Timer tmrHora;
        private System.Windows.Forms.GroupBox grpPrepar1;
        private System.Windows.Forms.PictureBox picPrep12;
        private System.Windows.Forms.PictureBox picPrep11;
        private System.Windows.Forms.GroupBox grpPrepar2;
        private System.Windows.Forms.PictureBox picPrep22;
        private System.Windows.Forms.PictureBox picPrep21;
        private System.Windows.Forms.ListView listEspera;
        private System.Windows.Forms.ColumnHeader nomeClient;
        private System.Windows.Forms.Label lblEsp;
        private System.Windows.Forms.Timer tmrProcess2;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblPrepITem1;
        private System.Windows.Forms.Label lblPrepNome1;
        private System.Windows.Forms.Label lblCount1;
        private System.Windows.Forms.Label lblPrepITem2;
        private System.Windows.Forms.Label lblPrepNome2;
        private System.Windows.Forms.Label lblCount2;
        private System.Windows.Forms.ColumnHeader itemNome;
        private System.Windows.Forms.ColumnHeader tmpItem;
        private System.Windows.Forms.GroupBox grpCozinha;
        private System.Windows.Forms.Button btnLoadCard;
        private System.Windows.Forms.Button btnEntreg;
        private System.Windows.Forms.ListView listEntrega;
        private System.Windows.Forms.ColumnHeader EntrNome;
        private System.Windows.Forms.Label lblListEntreg;
        private System.Windows.Forms.ColumnHeader EntrItem;
    }
}

