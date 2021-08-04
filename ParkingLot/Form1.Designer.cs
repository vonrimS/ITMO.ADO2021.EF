
namespace ParkingLot
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelStart = new System.Windows.Forms.Panel();
            this.textBoxCarNumSearch = new System.Windows.Forms.TextBox();
            this.textBoxSecondNameSearch = new System.Windows.Forms.TextBox();
            this.radioButtonPinOnMap = new System.Windows.Forms.RadioButton();
            this.radioButtonCarNum = new System.Windows.Forms.RadioButton();
            this.radioButtonSecondName = new System.Windows.Forms.RadioButton();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonAdmin = new System.Windows.Forms.Button();
            this.panelParkingMap = new System.Windows.Forms.Panel();
            this.place08 = new System.Windows.Forms.RadioButton();
            this.place03 = new System.Windows.Forms.RadioButton();
            this.place04 = new System.Windows.Forms.RadioButton();
            this.place05 = new System.Windows.Forms.RadioButton();
            this.place06 = new System.Windows.Forms.RadioButton();
            this.place07 = new System.Windows.Forms.RadioButton();
            this.place02 = new System.Windows.Forms.RadioButton();
            this.place01 = new System.Windows.Forms.RadioButton();
            this.parkingPlacesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.parkingLotV3DataSet = new ParkingLot.ParkingLotV3DataSet();
            this.panelResult = new System.Windows.Forms.Panel();
            this.panelStockPhoto = new System.Windows.Forms.Panel();
            this.buttonAddPhoto = new System.Windows.Forms.Button();
            this.panelPhotoThumbnail = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPlaceNum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCarNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSecondName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.panelAdmin = new System.Windows.Forms.Panel();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.parkingPlacesTableAdapter = new ParkingLot.ParkingLotV3DataSetTableAdapters.ParkingPlacesTableAdapter();
            this.buttonUpdateAndSave = new System.Windows.Forms.Button();
            this.panelStart.SuspendLayout();
            this.panelParkingMap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.parkingPlacesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkingLotV3DataSet)).BeginInit();
            this.panelResult.SuspendLayout();
            this.panelAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelStart
            // 
            this.panelStart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelStart.Controls.Add(this.textBoxCarNumSearch);
            this.panelStart.Controls.Add(this.textBoxSecondNameSearch);
            this.panelStart.Controls.Add(this.radioButtonPinOnMap);
            this.panelStart.Controls.Add(this.radioButtonCarNum);
            this.panelStart.Controls.Add(this.radioButtonSecondName);
            this.panelStart.Controls.Add(this.buttonSearch);
            this.panelStart.Location = new System.Drawing.Point(14, 14);
            this.panelStart.Margin = new System.Windows.Forms.Padding(5);
            this.panelStart.Name = "panelStart";
            this.panelStart.Padding = new System.Windows.Forms.Padding(5);
            this.panelStart.Size = new System.Drawing.Size(295, 162);
            this.panelStart.TabIndex = 0;
            // 
            // textBoxCarNumSearch
            // 
            this.textBoxCarNumSearch.Location = new System.Drawing.Point(185, 36);
            this.textBoxCarNumSearch.Name = "textBoxCarNumSearch";
            this.textBoxCarNumSearch.Size = new System.Drawing.Size(100, 20);
            this.textBoxCarNumSearch.TabIndex = 5;
            this.textBoxCarNumSearch.Visible = false;
            // 
            // textBoxSecondNameSearch
            // 
            this.textBoxSecondNameSearch.Location = new System.Drawing.Point(185, 7);
            this.textBoxSecondNameSearch.Name = "textBoxSecondNameSearch";
            this.textBoxSecondNameSearch.Size = new System.Drawing.Size(100, 20);
            this.textBoxSecondNameSearch.TabIndex = 4;
            // 
            // radioButtonPinOnMap
            // 
            this.radioButtonPinOnMap.AutoSize = true;
            this.radioButtonPinOnMap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonPinOnMap.Location = new System.Drawing.Point(8, 66);
            this.radioButtonPinOnMap.Name = "radioButtonPinOnMap";
            this.radioButtonPinOnMap.Size = new System.Drawing.Size(179, 19);
            this.radioButtonPinOnMap.TabIndex = 3;
            this.radioButtonPinOnMap.Text = "Искать на плане парковки";
            this.radioButtonPinOnMap.UseVisualStyleBackColor = true;
            this.radioButtonPinOnMap.CheckedChanged += new System.EventHandler(this.radioButtonPinOnMap_CheckedChanged);
            // 
            // radioButtonCarNum
            // 
            this.radioButtonCarNum.AutoSize = true;
            this.radioButtonCarNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonCarNum.Location = new System.Drawing.Point(8, 37);
            this.radioButtonCarNum.Name = "radioButtonCarNum";
            this.radioButtonCarNum.Size = new System.Drawing.Size(151, 19);
            this.radioButtonCarNum.TabIndex = 2;
            this.radioButtonCarNum.Text = "Искать по номеру а/м";
            this.radioButtonCarNum.UseVisualStyleBackColor = true;
            this.radioButtonCarNum.CheckedChanged += new System.EventHandler(this.radioButtonCarNum_CheckedChanged);
            // 
            // radioButtonSecondName
            // 
            this.radioButtonSecondName.AutoSize = true;
            this.radioButtonSecondName.Checked = true;
            this.radioButtonSecondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonSecondName.Location = new System.Drawing.Point(8, 8);
            this.radioButtonSecondName.Name = "radioButtonSecondName";
            this.radioButtonSecondName.Size = new System.Drawing.Size(142, 19);
            this.radioButtonSecondName.TabIndex = 1;
            this.radioButtonSecondName.TabStop = true;
            this.radioButtonSecondName.Text = "Искать по фамилии";
            this.radioButtonSecondName.UseVisualStyleBackColor = true;
            this.radioButtonSecondName.CheckedChanged += new System.EventHandler(this.radioButtonSecondName_CheckedChanged);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearch.Location = new System.Drawing.Point(10, 104);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(5);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(273, 44);
            this.buttonSearch.TabIndex = 0;
            this.buttonSearch.Text = "Найти";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonAdmin
            // 
            this.buttonAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdmin.Location = new System.Drawing.Point(14, 182);
            this.buttonAdmin.Name = "buttonAdmin";
            this.buttonAdmin.Size = new System.Drawing.Size(295, 33);
            this.buttonAdmin.TabIndex = 17;
            this.buttonAdmin.Text = "Редактивать данные";
            this.buttonAdmin.UseVisualStyleBackColor = true;
            this.buttonAdmin.Click += new System.EventHandler(this.buttonAdmin_Click);
            // 
            // panelParkingMap
            // 
            this.panelParkingMap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelParkingMap.BackgroundImage")));
            this.panelParkingMap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelParkingMap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelParkingMap.Controls.Add(this.place08);
            this.panelParkingMap.Controls.Add(this.place03);
            this.panelParkingMap.Controls.Add(this.place04);
            this.panelParkingMap.Controls.Add(this.place05);
            this.panelParkingMap.Controls.Add(this.place06);
            this.panelParkingMap.Controls.Add(this.place07);
            this.panelParkingMap.Controls.Add(this.place02);
            this.panelParkingMap.Controls.Add(this.place01);
            this.panelParkingMap.Location = new System.Drawing.Point(321, 14);
            this.panelParkingMap.Margin = new System.Windows.Forms.Padding(5);
            this.panelParkingMap.Name = "panelParkingMap";
            this.panelParkingMap.Size = new System.Drawing.Size(723, 640);
            this.panelParkingMap.TabIndex = 2;
            // 
            // place08
            // 
            this.place08.Appearance = System.Windows.Forms.Appearance.Button;
            this.place08.BackColor = System.Drawing.Color.Transparent;
            this.place08.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.place08.ForeColor = System.Drawing.Color.Black;
            this.place08.Location = new System.Drawing.Point(576, 414);
            this.place08.Name = "place08";
            this.place08.Size = new System.Drawing.Size(51, 106);
            this.place08.TabIndex = 15;
            this.place08.TabStop = true;
            this.place08.Tag = "8";
            this.place08.Text = "                    ";
            this.place08.UseVisualStyleBackColor = false;
            this.place08.Click += new System.EventHandler(this.place08_Click);
            // 
            // place03
            // 
            this.place03.Appearance = System.Windows.Forms.Appearance.Button;
            this.place03.BackColor = System.Drawing.Color.Transparent;
            this.place03.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.place03.ForeColor = System.Drawing.Color.Black;
            this.place03.Location = new System.Drawing.Point(229, 414);
            this.place03.Name = "place03";
            this.place03.Size = new System.Drawing.Size(51, 106);
            this.place03.TabIndex = 14;
            this.place03.TabStop = true;
            this.place03.Tag = "3";
            this.place03.Text = "                    ";
            this.place03.UseVisualStyleBackColor = false;
            this.place03.Click += new System.EventHandler(this.place03_Click);
            // 
            // place04
            // 
            this.place04.Appearance = System.Windows.Forms.Appearance.Button;
            this.place04.BackColor = System.Drawing.Color.Transparent;
            this.place04.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.place04.ForeColor = System.Drawing.Color.Black;
            this.place04.Location = new System.Drawing.Point(292, 414);
            this.place04.Name = "place04";
            this.place04.Size = new System.Drawing.Size(51, 106);
            this.place04.TabIndex = 13;
            this.place04.TabStop = true;
            this.place04.Tag = "4";
            this.place04.Text = "                    ";
            this.place04.UseVisualStyleBackColor = false;
            this.place04.Click += new System.EventHandler(this.place04_Click);
            // 
            // place05
            // 
            this.place05.Appearance = System.Windows.Forms.Appearance.Button;
            this.place05.BackColor = System.Drawing.Color.Transparent;
            this.place05.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.place05.ForeColor = System.Drawing.Color.Black;
            this.place05.Location = new System.Drawing.Point(371, 414);
            this.place05.Name = "place05";
            this.place05.Size = new System.Drawing.Size(51, 106);
            this.place05.TabIndex = 12;
            this.place05.TabStop = true;
            this.place05.Tag = "5";
            this.place05.Text = "                    ";
            this.place05.UseVisualStyleBackColor = false;
            this.place05.Click += new System.EventHandler(this.place05_Click);
            // 
            // place06
            // 
            this.place06.Appearance = System.Windows.Forms.Appearance.Button;
            this.place06.BackColor = System.Drawing.Color.Transparent;
            this.place06.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.place06.ForeColor = System.Drawing.Color.Black;
            this.place06.Location = new System.Drawing.Point(434, 414);
            this.place06.Name = "place06";
            this.place06.Size = new System.Drawing.Size(51, 106);
            this.place06.TabIndex = 11;
            this.place06.TabStop = true;
            this.place06.Tag = "6";
            this.place06.Text = "                    ";
            this.place06.UseVisualStyleBackColor = false;
            this.place06.Click += new System.EventHandler(this.place06_Click);
            // 
            // place07
            // 
            this.place07.Appearance = System.Windows.Forms.Appearance.Button;
            this.place07.BackColor = System.Drawing.Color.Transparent;
            this.place07.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.place07.ForeColor = System.Drawing.Color.Black;
            this.place07.Location = new System.Drawing.Point(513, 414);
            this.place07.Name = "place07";
            this.place07.Size = new System.Drawing.Size(51, 106);
            this.place07.TabIndex = 10;
            this.place07.TabStop = true;
            this.place07.Tag = "7";
            this.place07.Text = "                    ";
            this.place07.UseVisualStyleBackColor = false;
            this.place07.Click += new System.EventHandler(this.place07_Click);
            // 
            // place02
            // 
            this.place02.Appearance = System.Windows.Forms.Appearance.Button;
            this.place02.BackColor = System.Drawing.Color.Transparent;
            this.place02.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.place02.ForeColor = System.Drawing.Color.Black;
            this.place02.Location = new System.Drawing.Point(150, 414);
            this.place02.Name = "place02";
            this.place02.Size = new System.Drawing.Size(51, 106);
            this.place02.TabIndex = 9;
            this.place02.TabStop = true;
            this.place02.Tag = "2";
            this.place02.Text = "                    ";
            this.place02.UseVisualStyleBackColor = false;
            this.place02.Click += new System.EventHandler(this.place02_Click);
            // 
            // place01
            // 
            this.place01.Appearance = System.Windows.Forms.Appearance.Button;
            this.place01.BackColor = System.Drawing.Color.Transparent;
            this.place01.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.place01.ForeColor = System.Drawing.Color.Black;
            this.place01.Location = new System.Drawing.Point(86, 414);
            this.place01.Name = "place01";
            this.place01.Size = new System.Drawing.Size(51, 106);
            this.place01.TabIndex = 8;
            this.place01.TabStop = true;
            this.place01.Tag = "1";
            this.place01.Text = "       ";
            this.place01.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.place01.UseVisualStyleBackColor = false;
            this.place01.Click += new System.EventHandler(this.place01_Click);
            // 
            // parkingPlacesBindingSource
            // 
            this.parkingPlacesBindingSource.DataMember = "ParkingPlaces";
            this.parkingPlacesBindingSource.DataSource = this.parkingLotV3DataSet;
            // 
            // parkingLotV3DataSet
            // 
            this.parkingLotV3DataSet.DataSetName = "ParkingLotV3DataSet";
            this.parkingLotV3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panelResult
            // 
            this.panelResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelResult.Controls.Add(this.buttonUpdateAndSave);
            this.panelResult.Controls.Add(this.panelStockPhoto);
            this.panelResult.Controls.Add(this.buttonAddPhoto);
            this.panelResult.Controls.Add(this.panelPhotoThumbnail);
            this.panelResult.Controls.Add(this.label5);
            this.panelResult.Controls.Add(this.textBoxPlaceNum);
            this.panelResult.Controls.Add(this.label4);
            this.panelResult.Controls.Add(this.textBoxCarNum);
            this.panelResult.Controls.Add(this.label3);
            this.panelResult.Controls.Add(this.textBoxAge);
            this.panelResult.Controls.Add(this.label2);
            this.panelResult.Controls.Add(this.textBoxSecondName);
            this.panelResult.Controls.Add(this.label1);
            this.panelResult.Controls.Add(this.textBoxFirstName);
            this.panelResult.Enabled = false;
            this.panelResult.Location = new System.Drawing.Point(14, 223);
            this.panelResult.Margin = new System.Windows.Forms.Padding(5);
            this.panelResult.Name = "panelResult";
            this.panelResult.Padding = new System.Windows.Forms.Padding(5);
            this.panelResult.Size = new System.Drawing.Size(295, 277);
            this.panelResult.TabIndex = 3;
            // 
            // panelStockPhoto
            // 
            this.panelStockPhoto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelStockPhoto.BackgroundImage")));
            this.panelStockPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelStockPhoto.Location = new System.Drawing.Point(181, 157);
            this.panelStockPhoto.Name = "panelStockPhoto";
            this.panelStockPhoto.Size = new System.Drawing.Size(102, 106);
            this.panelStockPhoto.TabIndex = 17;
            // 
            // buttonAddPhoto
            // 
            this.buttonAddPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddPhoto.Location = new System.Drawing.Point(10, 230);
            this.buttonAddPhoto.Name = "buttonAddPhoto";
            this.buttonAddPhoto.Size = new System.Drawing.Size(151, 33);
            this.buttonAddPhoto.TabIndex = 16;
            this.buttonAddPhoto.Text = "Загрузить фото";
            this.buttonAddPhoto.UseVisualStyleBackColor = true;
            this.buttonAddPhoto.Click += new System.EventHandler(this.buttonAddPhoto_Click);
            // 
            // panelPhotoThumbnail
            // 
            this.panelPhotoThumbnail.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelPhotoThumbnail.BackgroundImage")));
            this.panelPhotoThumbnail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelPhotoThumbnail.Location = new System.Drawing.Point(181, 157);
            this.panelPhotoThumbnail.Name = "panelPhotoThumbnail";
            this.panelPhotoThumbnail.Size = new System.Drawing.Size(102, 106);
            this.panelPhotoThumbnail.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Машиноместо";
            // 
            // textBoxPlaceNum
            // 
            this.textBoxPlaceNum.Location = new System.Drawing.Point(124, 128);
            this.textBoxPlaceNum.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxPlaceNum.Name = "textBoxPlaceNum";
            this.textBoxPlaceNum.Size = new System.Drawing.Size(161, 20);
            this.textBoxPlaceNum.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Номер а/м";
            // 
            // textBoxCarNum
            // 
            this.textBoxCarNum.Location = new System.Drawing.Point(124, 98);
            this.textBoxCarNum.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxCarNum.Name = "textBoxCarNum";
            this.textBoxCarNum.Size = new System.Drawing.Size(161, 20);
            this.textBoxCarNum.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Возраст";
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(124, 68);
            this.textBoxAge.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(161, 20);
            this.textBoxAge.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Фамилия";
            // 
            // textBoxSecondName
            // 
            this.textBoxSecondName.Location = new System.Drawing.Point(124, 38);
            this.textBoxSecondName.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxSecondName.Name = "textBoxSecondName";
            this.textBoxSecondName.Size = new System.Drawing.Size(161, 20);
            this.textBoxSecondName.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Имя водителя";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(124, 8);
            this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(161, 20);
            this.textBoxFirstName.TabIndex = 5;
            // 
            // panelAdmin
            // 
            this.panelAdmin.BackColor = System.Drawing.Color.Transparent;
            this.panelAdmin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAdmin.Controls.Add(this.buttonDelete);
            this.panelAdmin.Controls.Add(this.buttonEdit);
            this.panelAdmin.Controls.Add(this.buttonAdd);
            this.panelAdmin.Location = new System.Drawing.Point(14, 510);
            this.panelAdmin.Margin = new System.Windows.Forms.Padding(5);
            this.panelAdmin.Name = "panelAdmin";
            this.panelAdmin.Padding = new System.Windows.Forms.Padding(5);
            this.panelAdmin.Size = new System.Drawing.Size(295, 144);
            this.panelAdmin.TabIndex = 4;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.Location = new System.Drawing.Point(8, 72);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(277, 62);
            this.buttonDelete.TabIndex = 20;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEdit.Location = new System.Drawing.Point(155, 8);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(130, 58);
            this.buttonEdit.TabIndex = 18;
            this.buttonEdit.Text = "Редактировать";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(8, 8);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(130, 58);
            this.buttonAdd.TabIndex = 17;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // parkingPlacesTableAdapter
            // 
            this.parkingPlacesTableAdapter.ClearBeforeFill = true;
            // 
            // buttonUpdateAndSave
            // 
            this.buttonUpdateAndSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUpdateAndSave.Location = new System.Drawing.Point(8, 157);
            this.buttonUpdateAndSave.Name = "buttonUpdateAndSave";
            this.buttonUpdateAndSave.Size = new System.Drawing.Size(151, 67);
            this.buttonUpdateAndSave.TabIndex = 18;
            this.buttonUpdateAndSave.Text = "Сохранить изменения";
            this.buttonUpdateAndSave.UseVisualStyleBackColor = true;
            this.buttonUpdateAndSave.Visible = false;
            this.buttonUpdateAndSave.Click += new System.EventHandler(this.buttonUpdateAndSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 668);
            this.Controls.Add(this.buttonAdmin);
            this.Controls.Add(this.panelAdmin);
            this.Controls.Add(this.panelResult);
            this.Controls.Add(this.panelParkingMap);
            this.Controls.Add(this.panelStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parking Lot App";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelStart.ResumeLayout(false);
            this.panelStart.PerformLayout();
            this.panelParkingMap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.parkingPlacesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkingLotV3DataSet)).EndInit();
            this.panelResult.ResumeLayout(false);
            this.panelResult.PerformLayout();
            this.panelAdmin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelStart;
        private System.Windows.Forms.Panel panelParkingMap;
        private System.Windows.Forms.Panel panelResult;
        private System.Windows.Forms.Panel panelAdmin;
        private System.Windows.Forms.RadioButton radioButtonPinOnMap;
        private System.Windows.Forms.RadioButton radioButtonCarNum;
        private System.Windows.Forms.RadioButton radioButtonSecondName;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxCarNumSearch;
        private System.Windows.Forms.TextBox textBoxSecondNameSearch;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPlaceNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCarNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSecondName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelPhotoThumbnail;
        private System.Windows.Forms.Button buttonAdmin;
        private System.Windows.Forms.Button buttonAddPhoto;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private ParkingLotV3DataSet parkingLotV3DataSet;
        private System.Windows.Forms.BindingSource parkingPlacesBindingSource;
        private ParkingLotV3DataSetTableAdapters.ParkingPlacesTableAdapter parkingPlacesTableAdapter;
        private System.Windows.Forms.RadioButton place08;
        private System.Windows.Forms.RadioButton place03;
        private System.Windows.Forms.RadioButton place04;
        private System.Windows.Forms.RadioButton place05;
        private System.Windows.Forms.RadioButton place06;
        private System.Windows.Forms.RadioButton place07;
        private System.Windows.Forms.RadioButton place02;
        private System.Windows.Forms.RadioButton place01;
        private System.Windows.Forms.Panel panelStockPhoto;
        private System.Windows.Forms.Button buttonUpdateAndSave;
    }
}