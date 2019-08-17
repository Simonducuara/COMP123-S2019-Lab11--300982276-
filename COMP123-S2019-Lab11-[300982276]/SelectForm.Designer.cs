namespace COMP123_S2019_Assignment5__300982276_
{
    partial class SelectForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SelectFormCancelButton = new System.Windows.Forms.Button();
            this.SelectFormNextButton = new System.Windows.Forms.Button();
            this.ProductsDataGridView = new System.Windows.Forms.DataGridView();
            this.dollarComputersDataSet = new COMP123_S2019_Assignment5__300982276_.DollarComputersDataSet();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new COMP123_S2019_Assignment5__300982276_.DollarComputersDataSetTableAdapters.productsTableAdapter();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAMtypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAMsizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.displaytypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.screensizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resolutionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPUClassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPUbrandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPUtypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPUspeedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPUnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conditionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.platformDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hDDsizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hDDspeedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gPUTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opticaldriveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.audiotypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lANDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wIFIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.widthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mousttypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.powerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.webcamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dollarComputersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dollar Computer Hardware List";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 399);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Your Selection";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SelectFormCancelButton
            // 
            this.SelectFormCancelButton.Location = new System.Drawing.Point(503, 399);
            this.SelectFormCancelButton.Name = "SelectFormCancelButton";
            this.SelectFormCancelButton.Size = new System.Drawing.Size(75, 23);
            this.SelectFormCancelButton.TabIndex = 2;
            this.SelectFormCancelButton.Text = "Cancel";
            this.SelectFormCancelButton.UseVisualStyleBackColor = true;
            this.SelectFormCancelButton.Click += new System.EventHandler(this.SelectFormCancelButton_Click);
            // 
            // SelectFormNextButton
            // 
            this.SelectFormNextButton.Location = new System.Drawing.Point(612, 399);
            this.SelectFormNextButton.Name = "SelectFormNextButton";
            this.SelectFormNextButton.Size = new System.Drawing.Size(75, 23);
            this.SelectFormNextButton.TabIndex = 3;
            this.SelectFormNextButton.Text = "Next";
            this.SelectFormNextButton.UseVisualStyleBackColor = true;
            this.SelectFormNextButton.Click += new System.EventHandler(this.SelectFormNextButton_Click);
            // 
            // ProductsDataGridView
            // 
            this.ProductsDataGridView.AllowUserToAddRows = false;
            this.ProductsDataGridView.AllowUserToDeleteRows = false;
            this.ProductsDataGridView.AllowUserToResizeColumns = false;
            this.ProductsDataGridView.AllowUserToResizeRows = false;
            this.ProductsDataGridView.AutoGenerateColumns = false;
            this.ProductsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.ProductsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.ProductsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.manufacturerDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.rAMtypeDataGridViewTextBoxColumn,
            this.rAMsizeDataGridViewTextBoxColumn,
            this.displaytypeDataGridViewTextBoxColumn,
            this.screensizeDataGridViewTextBoxColumn,
            this.resolutionDataGridViewTextBoxColumn,
            this.cPUClassDataGridViewTextBoxColumn,
            this.cPUbrandDataGridViewTextBoxColumn,
            this.cPUtypeDataGridViewTextBoxColumn,
            this.cPUspeedDataGridViewTextBoxColumn,
            this.cPUnumberDataGridViewTextBoxColumn,
            this.conditionDataGridViewTextBoxColumn,
            this.oSDataGridViewTextBoxColumn,
            this.platformDataGridViewTextBoxColumn,
            this.hDDsizeDataGridViewTextBoxColumn,
            this.hDDspeedDataGridViewTextBoxColumn,
            this.gPUTypeDataGridViewTextBoxColumn,
            this.opticaldriveDataGridViewTextBoxColumn,
            this.audiotypeDataGridViewTextBoxColumn,
            this.lANDataGridViewTextBoxColumn,
            this.wIFIDataGridViewTextBoxColumn,
            this.widthDataGridViewTextBoxColumn,
            this.heightDataGridViewTextBoxColumn,
            this.depthDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn,
            this.mousttypeDataGridViewTextBoxColumn,
            this.powerDataGridViewTextBoxColumn,
            this.webcamDataGridViewTextBoxColumn});
            this.ProductsDataGridView.DataSource = this.productsBindingSource;
            this.ProductsDataGridView.Location = new System.Drawing.Point(45, 59);
            this.ProductsDataGridView.MultiSelect = false;
            this.ProductsDataGridView.Name = "ProductsDataGridView";
            this.ProductsDataGridView.ReadOnly = true;
            this.ProductsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductsDataGridView.Size = new System.Drawing.Size(628, 310);
            this.ProductsDataGridView.TabIndex = 5;
            this.ProductsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductsDataGridView_CellContentClick);
            this.ProductsDataGridView.SelectionChanged += new System.EventHandler(this.ProductsDataGridView_SelectionChanged);
            // 
            // dollarComputersDataSet
            // 
            this.dollarComputersDataSet.DataSetName = "DollarComputersDataSet";
            this.dollarComputersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "products";
            this.productsBindingSource.DataSource = this.dollarComputersDataSet;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "productID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "productID";
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.productIDDataGridViewTextBoxColumn.Width = 79;
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "cost";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.ReadOnly = true;
            this.costDataGridViewTextBoxColumn.Width = 52;
            // 
            // manufacturerDataGridViewTextBoxColumn
            // 
            this.manufacturerDataGridViewTextBoxColumn.DataPropertyName = "manufacturer";
            this.manufacturerDataGridViewTextBoxColumn.HeaderText = "manufacturer";
            this.manufacturerDataGridViewTextBoxColumn.Name = "manufacturerDataGridViewTextBoxColumn";
            this.manufacturerDataGridViewTextBoxColumn.ReadOnly = true;
            this.manufacturerDataGridViewTextBoxColumn.Width = 94;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.ReadOnly = true;
            this.modelDataGridViewTextBoxColumn.Width = 60;
            // 
            // rAMtypeDataGridViewTextBoxColumn
            // 
            this.rAMtypeDataGridViewTextBoxColumn.DataPropertyName = "RAM_type";
            this.rAMtypeDataGridViewTextBoxColumn.HeaderText = "RAM_type";
            this.rAMtypeDataGridViewTextBoxColumn.Name = "rAMtypeDataGridViewTextBoxColumn";
            this.rAMtypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.rAMtypeDataGridViewTextBoxColumn.Width = 82;
            // 
            // rAMsizeDataGridViewTextBoxColumn
            // 
            this.rAMsizeDataGridViewTextBoxColumn.DataPropertyName = "RAM_size";
            this.rAMsizeDataGridViewTextBoxColumn.HeaderText = "RAM_size";
            this.rAMsizeDataGridViewTextBoxColumn.Name = "rAMsizeDataGridViewTextBoxColumn";
            this.rAMsizeDataGridViewTextBoxColumn.ReadOnly = true;
            this.rAMsizeDataGridViewTextBoxColumn.Width = 80;
            // 
            // displaytypeDataGridViewTextBoxColumn
            // 
            this.displaytypeDataGridViewTextBoxColumn.DataPropertyName = "displaytype";
            this.displaytypeDataGridViewTextBoxColumn.HeaderText = "displaytype";
            this.displaytypeDataGridViewTextBoxColumn.Name = "displaytypeDataGridViewTextBoxColumn";
            this.displaytypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.displaytypeDataGridViewTextBoxColumn.Width = 84;
            // 
            // screensizeDataGridViewTextBoxColumn
            // 
            this.screensizeDataGridViewTextBoxColumn.DataPropertyName = "screensize";
            this.screensizeDataGridViewTextBoxColumn.HeaderText = "screensize";
            this.screensizeDataGridViewTextBoxColumn.Name = "screensizeDataGridViewTextBoxColumn";
            this.screensizeDataGridViewTextBoxColumn.ReadOnly = true;
            this.screensizeDataGridViewTextBoxColumn.Width = 82;
            // 
            // resolutionDataGridViewTextBoxColumn
            // 
            this.resolutionDataGridViewTextBoxColumn.DataPropertyName = "resolution";
            this.resolutionDataGridViewTextBoxColumn.HeaderText = "resolution";
            this.resolutionDataGridViewTextBoxColumn.Name = "resolutionDataGridViewTextBoxColumn";
            this.resolutionDataGridViewTextBoxColumn.ReadOnly = true;
            this.resolutionDataGridViewTextBoxColumn.Width = 77;
            // 
            // cPUClassDataGridViewTextBoxColumn
            // 
            this.cPUClassDataGridViewTextBoxColumn.DataPropertyName = "CPU_Class";
            this.cPUClassDataGridViewTextBoxColumn.HeaderText = "CPU_Class";
            this.cPUClassDataGridViewTextBoxColumn.Name = "cPUClassDataGridViewTextBoxColumn";
            this.cPUClassDataGridViewTextBoxColumn.ReadOnly = true;
            this.cPUClassDataGridViewTextBoxColumn.Width = 85;
            // 
            // cPUbrandDataGridViewTextBoxColumn
            // 
            this.cPUbrandDataGridViewTextBoxColumn.DataPropertyName = "CPU_brand";
            this.cPUbrandDataGridViewTextBoxColumn.HeaderText = "CPU_brand";
            this.cPUbrandDataGridViewTextBoxColumn.Name = "cPUbrandDataGridViewTextBoxColumn";
            this.cPUbrandDataGridViewTextBoxColumn.ReadOnly = true;
            this.cPUbrandDataGridViewTextBoxColumn.Width = 87;
            // 
            // cPUtypeDataGridViewTextBoxColumn
            // 
            this.cPUtypeDataGridViewTextBoxColumn.DataPropertyName = "CPU_type";
            this.cPUtypeDataGridViewTextBoxColumn.HeaderText = "CPU_type";
            this.cPUtypeDataGridViewTextBoxColumn.Name = "cPUtypeDataGridViewTextBoxColumn";
            this.cPUtypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.cPUtypeDataGridViewTextBoxColumn.Width = 80;
            // 
            // cPUspeedDataGridViewTextBoxColumn
            // 
            this.cPUspeedDataGridViewTextBoxColumn.DataPropertyName = "CPU_speed";
            this.cPUspeedDataGridViewTextBoxColumn.HeaderText = "CPU_speed";
            this.cPUspeedDataGridViewTextBoxColumn.Name = "cPUspeedDataGridViewTextBoxColumn";
            this.cPUspeedDataGridViewTextBoxColumn.ReadOnly = true;
            this.cPUspeedDataGridViewTextBoxColumn.Width = 89;
            // 
            // cPUnumberDataGridViewTextBoxColumn
            // 
            this.cPUnumberDataGridViewTextBoxColumn.DataPropertyName = "CPU_number";
            this.cPUnumberDataGridViewTextBoxColumn.HeaderText = "CPU_number";
            this.cPUnumberDataGridViewTextBoxColumn.Name = "cPUnumberDataGridViewTextBoxColumn";
            this.cPUnumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.cPUnumberDataGridViewTextBoxColumn.Width = 95;
            // 
            // conditionDataGridViewTextBoxColumn
            // 
            this.conditionDataGridViewTextBoxColumn.DataPropertyName = "condition";
            this.conditionDataGridViewTextBoxColumn.HeaderText = "condition";
            this.conditionDataGridViewTextBoxColumn.Name = "conditionDataGridViewTextBoxColumn";
            this.conditionDataGridViewTextBoxColumn.ReadOnly = true;
            this.conditionDataGridViewTextBoxColumn.Width = 75;
            // 
            // oSDataGridViewTextBoxColumn
            // 
            this.oSDataGridViewTextBoxColumn.DataPropertyName = "OS";
            this.oSDataGridViewTextBoxColumn.HeaderText = "OS";
            this.oSDataGridViewTextBoxColumn.Name = "oSDataGridViewTextBoxColumn";
            this.oSDataGridViewTextBoxColumn.ReadOnly = true;
            this.oSDataGridViewTextBoxColumn.Width = 47;
            // 
            // platformDataGridViewTextBoxColumn
            // 
            this.platformDataGridViewTextBoxColumn.DataPropertyName = "platform";
            this.platformDataGridViewTextBoxColumn.HeaderText = "platform";
            this.platformDataGridViewTextBoxColumn.Name = "platformDataGridViewTextBoxColumn";
            this.platformDataGridViewTextBoxColumn.ReadOnly = true;
            this.platformDataGridViewTextBoxColumn.Width = 69;
            // 
            // hDDsizeDataGridViewTextBoxColumn
            // 
            this.hDDsizeDataGridViewTextBoxColumn.DataPropertyName = "HDD_size";
            this.hDDsizeDataGridViewTextBoxColumn.HeaderText = "HDD_size";
            this.hDDsizeDataGridViewTextBoxColumn.Name = "hDDsizeDataGridViewTextBoxColumn";
            this.hDDsizeDataGridViewTextBoxColumn.ReadOnly = true;
            this.hDDsizeDataGridViewTextBoxColumn.Width = 80;
            // 
            // hDDspeedDataGridViewTextBoxColumn
            // 
            this.hDDspeedDataGridViewTextBoxColumn.DataPropertyName = "HDD_speed";
            this.hDDspeedDataGridViewTextBoxColumn.HeaderText = "HDD_speed";
            this.hDDspeedDataGridViewTextBoxColumn.Name = "hDDspeedDataGridViewTextBoxColumn";
            this.hDDspeedDataGridViewTextBoxColumn.ReadOnly = true;
            this.hDDspeedDataGridViewTextBoxColumn.Width = 91;
            // 
            // gPUTypeDataGridViewTextBoxColumn
            // 
            this.gPUTypeDataGridViewTextBoxColumn.DataPropertyName = "GPU_Type";
            this.gPUTypeDataGridViewTextBoxColumn.HeaderText = "GPU_Type";
            this.gPUTypeDataGridViewTextBoxColumn.Name = "gPUTypeDataGridViewTextBoxColumn";
            this.gPUTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.gPUTypeDataGridViewTextBoxColumn.Width = 85;
            // 
            // opticaldriveDataGridViewTextBoxColumn
            // 
            this.opticaldriveDataGridViewTextBoxColumn.DataPropertyName = "optical_drive";
            this.opticaldriveDataGridViewTextBoxColumn.HeaderText = "optical_drive";
            this.opticaldriveDataGridViewTextBoxColumn.Name = "opticaldriveDataGridViewTextBoxColumn";
            this.opticaldriveDataGridViewTextBoxColumn.ReadOnly = true;
            this.opticaldriveDataGridViewTextBoxColumn.Width = 92;
            // 
            // audiotypeDataGridViewTextBoxColumn
            // 
            this.audiotypeDataGridViewTextBoxColumn.DataPropertyName = "Audio_type";
            this.audiotypeDataGridViewTextBoxColumn.HeaderText = "Audio_type";
            this.audiotypeDataGridViewTextBoxColumn.Name = "audiotypeDataGridViewTextBoxColumn";
            this.audiotypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.audiotypeDataGridViewTextBoxColumn.Width = 85;
            // 
            // lANDataGridViewTextBoxColumn
            // 
            this.lANDataGridViewTextBoxColumn.DataPropertyName = "LAN";
            this.lANDataGridViewTextBoxColumn.HeaderText = "LAN";
            this.lANDataGridViewTextBoxColumn.Name = "lANDataGridViewTextBoxColumn";
            this.lANDataGridViewTextBoxColumn.ReadOnly = true;
            this.lANDataGridViewTextBoxColumn.Width = 53;
            // 
            // wIFIDataGridViewTextBoxColumn
            // 
            this.wIFIDataGridViewTextBoxColumn.DataPropertyName = "WIFI";
            this.wIFIDataGridViewTextBoxColumn.HeaderText = "WIFI";
            this.wIFIDataGridViewTextBoxColumn.Name = "wIFIDataGridViewTextBoxColumn";
            this.wIFIDataGridViewTextBoxColumn.ReadOnly = true;
            this.wIFIDataGridViewTextBoxColumn.Width = 55;
            // 
            // widthDataGridViewTextBoxColumn
            // 
            this.widthDataGridViewTextBoxColumn.DataPropertyName = "width";
            this.widthDataGridViewTextBoxColumn.HeaderText = "width";
            this.widthDataGridViewTextBoxColumn.Name = "widthDataGridViewTextBoxColumn";
            this.widthDataGridViewTextBoxColumn.ReadOnly = true;
            this.widthDataGridViewTextBoxColumn.Width = 57;
            // 
            // heightDataGridViewTextBoxColumn
            // 
            this.heightDataGridViewTextBoxColumn.DataPropertyName = "height";
            this.heightDataGridViewTextBoxColumn.HeaderText = "height";
            this.heightDataGridViewTextBoxColumn.Name = "heightDataGridViewTextBoxColumn";
            this.heightDataGridViewTextBoxColumn.ReadOnly = true;
            this.heightDataGridViewTextBoxColumn.Width = 61;
            // 
            // depthDataGridViewTextBoxColumn
            // 
            this.depthDataGridViewTextBoxColumn.DataPropertyName = "depth";
            this.depthDataGridViewTextBoxColumn.HeaderText = "depth";
            this.depthDataGridViewTextBoxColumn.Name = "depthDataGridViewTextBoxColumn";
            this.depthDataGridViewTextBoxColumn.ReadOnly = true;
            this.depthDataGridViewTextBoxColumn.Width = 59;
            // 
            // weightDataGridViewTextBoxColumn
            // 
            this.weightDataGridViewTextBoxColumn.DataPropertyName = "weight";
            this.weightDataGridViewTextBoxColumn.HeaderText = "weight";
            this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            this.weightDataGridViewTextBoxColumn.ReadOnly = true;
            this.weightDataGridViewTextBoxColumn.Width = 63;
            // 
            // mousttypeDataGridViewTextBoxColumn
            // 
            this.mousttypeDataGridViewTextBoxColumn.DataPropertyName = "moust_type";
            this.mousttypeDataGridViewTextBoxColumn.HeaderText = "moust_type";
            this.mousttypeDataGridViewTextBoxColumn.Name = "mousttypeDataGridViewTextBoxColumn";
            this.mousttypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.mousttypeDataGridViewTextBoxColumn.Width = 86;
            // 
            // powerDataGridViewTextBoxColumn
            // 
            this.powerDataGridViewTextBoxColumn.DataPropertyName = "power";
            this.powerDataGridViewTextBoxColumn.HeaderText = "power";
            this.powerDataGridViewTextBoxColumn.Name = "powerDataGridViewTextBoxColumn";
            this.powerDataGridViewTextBoxColumn.ReadOnly = true;
            this.powerDataGridViewTextBoxColumn.Width = 61;
            // 
            // webcamDataGridViewTextBoxColumn
            // 
            this.webcamDataGridViewTextBoxColumn.DataPropertyName = "webcam";
            this.webcamDataGridViewTextBoxColumn.HeaderText = "webcam";
            this.webcamDataGridViewTextBoxColumn.Name = "webcamDataGridViewTextBoxColumn";
            this.webcamDataGridViewTextBoxColumn.ReadOnly = true;
            this.webcamDataGridViewTextBoxColumn.Width = 72;
            // 
            // SelectLabel
            // 
            this.SelectLabel.BackColor = System.Drawing.Color.DarkGray;
            this.SelectLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SelectLabel.Location = new System.Drawing.Point(118, 399);
            this.SelectLabel.Name = "SelectLabel";
            this.SelectLabel.Size = new System.Drawing.Size(355, 23);
            this.SelectLabel.TabIndex = 6;
            this.SelectLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 471);
            this.ControlBox = false;
            this.Controls.Add(this.SelectLabel);
            this.Controls.Add(this.ProductsDataGridView);
            this.Controls.Add(this.SelectFormNextButton);
            this.Controls.Add(this.SelectFormCancelButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SelectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Your Computer";
            this.Load += new System.EventHandler(this.SelectForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dollarComputersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SelectFormCancelButton;
        private System.Windows.Forms.Button SelectFormNextButton;
        private System.Windows.Forms.DataGridView ProductsDataGridView;
        private DollarComputersDataSet dollarComputersDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private DollarComputersDataSetTableAdapters.productsTableAdapter productsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAMtypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAMsizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn displaytypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn screensizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resolutionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPUClassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPUbrandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPUtypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPUspeedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPUnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conditionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn platformDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hDDsizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hDDspeedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gPUTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opticaldriveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn audiotypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lANDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wIFIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn widthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn depthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mousttypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn powerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn webcamDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label SelectLabel;
    }
}