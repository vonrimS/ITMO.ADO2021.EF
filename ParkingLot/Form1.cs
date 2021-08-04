using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ParkingLot
{
    public partial class Form1 : Form
    {
        SampleContext context = new SampleContext();
        byte[] Ph;
        int thisParkingPlace;
        int currentId;
        int currentPlaceNum;

        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(337, 552);
            this.panelAdmin.Hide();
            this.panelParkingMap.Hide();
            this.panelStockPhoto.Show();
            this.panelPhotoThumbnail.Hide();
            
            place01.FlatAppearance.MouseOverBackColor = Color.LawnGreen;
            place02.FlatAppearance.MouseOverBackColor = Color.LawnGreen;
            place03.FlatAppearance.MouseOverBackColor = Color.LawnGreen;
            place04.FlatAppearance.MouseOverBackColor = Color.LawnGreen;
            place05.FlatAppearance.MouseOverBackColor = Color.LawnGreen;
            place06.FlatAppearance.MouseOverBackColor = Color.LawnGreen;
            place07.FlatAppearance.MouseOverBackColor = Color.LawnGreen;
            place08.FlatAppearance.MouseOverBackColor = Color.LawnGreen;
        }

        private void cleanTextBoxes()
        {
            textBoxFirstName.Text = String.Empty;
            textBoxSecondName.Text = String.Empty;
            textBoxAge.Text = String.Empty;
            textBoxCarNum.Text = String.Empty;
            textBoxPlaceNum.Text = String.Empty;
            textBoxCarNumSearch.Text = String.Empty;
            textBoxSecondNameSearch.Text = String.Empty;
        }

        private void uncheckParkingPlaces()
        {
            place01.Checked = false;
            place02.Checked = false;
            place03.Checked = false;
            place04.Checked = false;
            place05.Checked = false;
            place06.Checked = false;
            place07.Checked = false;
            place08.Checked = false;
        }
        

        private void radioButtonCarNum_CheckedChanged(object sender, EventArgs e)
        {
            uncheckParkingPlaces();
            cleanTextBoxes();
            panelResult.Enabled = false;
            this.panelStockPhoto.Show();
            this.panelPhotoThumbnail.Hide();

            this.textBoxSecondNameSearch.Hide();
            this.textBoxCarNumSearch.Show();
            this.panelParkingMap.Hide();
            this.Size = new Size(337, 552);
            this.panelAdmin.Hide();
        }

        private void radioButtonPinOnMap_CheckedChanged(object sender, EventArgs e)
        {
            uncheckParkingPlaces();
            cleanTextBoxes();

            panelResult.Enabled = false;
            this.panelStockPhoto.Show();
            this.panelPhotoThumbnail.Hide();

            this.textBoxSecondNameSearch.Hide();
            this.textBoxCarNumSearch.Hide();
            this.Size = new Size(1074, 707);
            this.panelParkingMap.Show();            
        }

        private void radioButtonSecondName_CheckedChanged(object sender, EventArgs e)
        {
            uncheckParkingPlaces();
            cleanTextBoxes();

            panelResult.Enabled = false;
            this.panelStockPhoto.Show();
            this.panelPhotoThumbnail.Hide();

            this.textBoxSecondNameSearch.Show();
            this.textBoxCarNumSearch.Hide();
            this.panelParkingMap.Hide();
            this.Size = new Size(337, 552);
            this.panelAdmin.Hide();
        }      

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            panelAdmin.Enabled = true;
            panelResult.Enabled = true;

            if (this.Size.Width == 337)
            {
                if (this.panelAdmin.Visible == false)
                {
                    this.Size = new Size(337, 707);
                    panelAdmin.Show();
                    panelResult.Enabled = true;                    
                }
                else
                {
                    this.Size = new Size(337, 552);
                    this.panelAdmin.Hide();
                }
            } else if (this.Size.Width == 1074)
            {
                if (this.panelAdmin.Visible == false)
                {
                    this.Size = new Size(1074, 707);
                    this.panelAdmin.Show();
                }
                else
                {
                    this.Size = new Size(1074, 707);
                    this.panelAdmin.Hide();
                }
            }                           
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var d = context.Drivers.Where(r => r.PlaceNum.ToString() == textBoxPlaceNum.Text);
            if (d.Count() == 0)
            {
                if (textBoxFirstName.Text.Length > 0 &&
                textBoxSecondName.Text.Length > 0 &&
                textBoxAge.Text.Length > 0 &&
                textBoxCarNum.Text.Length > 0 &&
                textBoxPlaceNum.Text.Length > 0 &&
                Ph.Length > 0)
                {
                    try
                    {
                        Driver driver = new Driver
                        {
                            FirstName = textBoxFirstName.Text,
                            SecondName = textBoxSecondName.Text,
                            DriverAge = Int32.Parse(textBoxAge.Text),
                            DriverPhoto = Ph,
                            CarNum = textBoxCarNum.Text,
                            PlaceNum = Int32.Parse(textBoxPlaceNum.Text)
                        };
                        context.Drivers.Add(driver);
                        context.SaveChanges();

                        MessageBox.Show("Пользователь успешно добавлен в базу данных");
                        cleanTextBoxes();
                        panelStockPhoto.Show();
                        panelPhotoThumbnail.Hide();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка: " + ex.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Заполните соответсвующие поля формы и загрузите фотографию водителя для внесения в базу данных");
                }
            }
            else
            {
                MessageBox.Show("Место уже занято. Сверьтесь с картой парковочных мест на наличие свободных мест для оформленя.");
                textBoxPlaceNum.Text = string.Empty;
            }               
                  
        }

        private void choosePhoto()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Image bm = new Bitmap(dialog.OpenFile());

                ImageConverter converter = new ImageConverter();
                Ph = (byte[])converter.ConvertTo(bm, typeof(byte[]));

                panelPhotoThumbnail.BackgroundImage = bm;
                panelPhotoThumbnail.BackgroundImageLayout = ImageLayout.Zoom;
                panelPhotoThumbnail.Show();
                panelStockPhoto.Hide();
            }
        }

        private void buttonAddPhoto_Click(object sender, EventArgs e)
        {
            choosePhoto();            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'parkingLotV3DataSet.ParkingPlaces' table. You can move, or remove it, as needed.
            this.parkingPlacesTableAdapter.Fill(this.parkingLotV3DataSet.ParkingPlaces);
        }           
              

        private void place01_Click(object sender, EventArgs e)
        {
            thisParkingPlace = 1;
        }

        private void place02_Click(object sender, EventArgs e)
        {
            thisParkingPlace = 2;
        }

        private void place03_Click(object sender, EventArgs e)
        {
            thisParkingPlace = 3;
        }

        private void place04_Click(object sender, EventArgs e)
        {
            thisParkingPlace = 4;
        }

        private void place05_Click(object sender, EventArgs e)
        {
            thisParkingPlace = 5;
        }

        private void place06_Click(object sender, EventArgs e)
        {
            thisParkingPlace = 6;
        }

        private void place07_Click(object sender, EventArgs e)
        {
            thisParkingPlace = 7;
        }

        private void place08_Click(object sender, EventArgs e)
        {
            thisParkingPlace = 8;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (radioButtonCarNum.Checked && textBoxCarNumSearch.Text.Length != 0)
            {
                //MessageBox.Show("Поиск по номеру");
                this.panelResult.Enabled = true;
                try
                {
                    var d = context.Drivers.Where(r => r.CarNum == textBoxCarNumSearch.Text).Select(r => new { r.FirstName, r.SecondName, r.DriverAge, r.CarNum, r.PlaceNum, r.DriverPhoto });
                    if (d.Count() > 0)
                    {
                        panelResult.Enabled = false;
                        this.panelStockPhoto.Hide();
                        this.panelPhotoThumbnail.Show();
                        //cleanTextBoxes();

                        foreach (var p in d)
                        {
                            MessageBox.Show("Водитель транспортного средства с номером " + p.CarNum + " успешно найден в базе");

                            this.textBoxFirstName.Text = p.FirstName;
                            this.textBoxSecondName.Text = p.SecondName;
                            this.textBoxAge.Text = p.DriverAge.ToString();
                            this.textBoxCarNum.Text = p.CarNum;
                            this.textBoxPlaceNum.Text = p.PlaceNum.ToString();
                            MemoryStream stream = new MemoryStream(p.DriverPhoto);
                            Image img = Image.FromStream(stream);
                            this.panelPhotoThumbnail.BackgroundImage = img;
                            this.panelPhotoThumbnail.BackgroundImageLayout = ImageLayout.Zoom;
                            this.panelStockPhoto.Hide();
                            this.panelPhotoThumbnail.Show();
                            stream.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Данные отсутсвуют");
                        cleanTextBoxes();
                        this.panelResult.Enabled = false;
                        this.panelStockPhoto.Show();
                        this.panelPhotoThumbnail.Hide();
                        textBoxCarNumSearch.Text = string.Empty;

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (radioButtonSecondName.Checked && textBoxSecondNameSearch.Text.Length != 0)
            {
                //MessageBox.Show("Поиск по фамилии");
                this.panelResult.Enabled = true;

                try
                {
                    var d = context.Drivers.Where(r => r.SecondName == textBoxSecondNameSearch.Text).Select(r => new { r.FirstName, r.SecondName, r.DriverAge, r.CarNum, r.PlaceNum, r.DriverPhoto });

                    if (d.Count() > 0)
                    {
                        panelResult.Enabled = false;
                        this.panelStockPhoto.Hide();
                        this.panelPhotoThumbnail.Show();
                        //cleanTextBoxes();

                        foreach (var p in d)
                        {
                            MessageBox.Show("Водитель транспортного средства по фамилии " + p.SecondName + " успешно найден в базе");

                            this.textBoxFirstName.Text = p.FirstName;
                            this.textBoxSecondName.Text = p.SecondName;
                            this.textBoxAge.Text = p.DriverAge.ToString();
                            this.textBoxCarNum.Text = p.CarNum;
                            this.textBoxPlaceNum.Text = p.PlaceNum.ToString();
                            MemoryStream stream = new MemoryStream(p.DriverPhoto);
                            Image img = Image.FromStream(stream);
                            this.panelPhotoThumbnail.BackgroundImage = img;
                            this.panelPhotoThumbnail.BackgroundImageLayout = ImageLayout.Zoom;
                            stream.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Данные отсутсвуют");
                        cleanTextBoxes();
                        this.panelResult.Enabled = false;
                        this.panelStockPhoto.Show();
                        this.panelPhotoThumbnail.Hide();
                        textBoxSecondNameSearch.Text = string.Empty;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else if (radioButtonPinOnMap.Checked && thisParkingPlace != 0)
            {
                //MessageBox.Show("Поиск по карте");
                this.panelResult.Enabled = true;
                try
                {
                    var d = context.Drivers.Where(r => r.PlaceNum == thisParkingPlace).Select(r => new { r.FirstName, r.SecondName, r.DriverAge, r.CarNum, r.PlaceNum, r.DriverPhoto });

                    if (d.Count() > 0)
                    {
                        panelResult.Enabled = false;
                        cleanTextBoxes();
                        foreach (var p in d)
                        {
                            this.textBoxFirstName.Text = p.FirstName;
                            this.textBoxSecondName.Text = p.SecondName;
                            this.textBoxAge.Text = p.DriverAge.ToString();
                            this.textBoxCarNum.Text = p.CarNum;
                            this.textBoxPlaceNum.Text = p.PlaceNum.ToString();
                            MemoryStream stream = new MemoryStream(p.DriverPhoto);
                            Image img = Image.FromStream(stream);
                            this.panelPhotoThumbnail.BackgroundImage = img;
                            this.panelPhotoThumbnail.BackgroundImageLayout = ImageLayout.Zoom;
                            this.panelStockPhoto.Hide();
                            this.panelPhotoThumbnail.Show();
                            MessageBox.Show("Водитель транспортного средства занимающий место № " + p.PlaceNum + " успешно найден в базе");
                            stream.Close();
                        }
                    }
                    else
                    {
                        cleanTextBoxes();
                        this.panelStockPhoto.Show();
                        this.panelPhotoThumbnail.Hide();
                        textBoxPlaceNum.Enabled = true;
                        MessageBox.Show("Выбранное место свободно");
                        panelResult.Enabled = false;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Недостаточно данных для поиска");
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {

            if (textBoxFirstName.Text.Length > 0 &&
               textBoxSecondName.Text.Length > 0 &&
                textBoxCarNum.Text.Length > 0)
            {
                //var d = context.Drivers.Where(r => r.aceNum == thisParkingPlace).Select(r => new { r.FirstName, r.SecondName, r.DriverAge, r.CarNum, r.PlaceNum, r.DriverPhoto });
                buttonUpdateAndSave.Visible = true;
                panelResult.Enabled = true;
                panelAdmin.Enabled = false;
                textBoxPlaceNum.Enabled = false;
               
                var driverToUpdate = context.Drivers.SingleOrDefault(r => r.SecondName == textBoxSecondName.Text && r.FirstName == textBoxFirstName.Text);
                currentId = driverToUpdate.DriverId;                
            }
            else
            {
                MessageBox.Show("Выберите профиль для редактирования через кнопку поиска с заполнением соотсветсвующих данных");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (textBoxFirstName.Text.Length > 0 &&
               textBoxSecondName.Text.Length > 0 &&
                textBoxCarNum.Text.Length > 0)
            {
                var driverToDelete = context.Drivers.SingleOrDefault(r => r.SecondName == textBoxSecondName.Text && r.FirstName == textBoxFirstName.Text);
                if (driverToDelete != null)
                {
                    context.Drivers.Remove(driverToDelete);
                    DialogResult dr = MessageBox.Show("Вы действительно хотите удалить выбраного пользователя?", "Подтвердите действие", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        context.SaveChanges();
                        MessageBox.Show("Пользователь удален");
                        cleanTextBoxes();
                        panelPhotoThumbnail.Hide();
                        panelStockPhoto.Show();
                    }
                    else if (dr == DialogResult.No) {
                        //не удалять
                    }                    
                }
            }
            else
            {
                MessageBox.Show("Выберите профиль для удаления через кнопку поиска с заполнением соотсветсвующих данных");
            }
        }

        private void buttonUpdateAndSave_Click(object sender, EventArgs e)
        {
            try
            {               
                var driver = context.Drivers.Find(currentId);
                DialogResult dr = MessageBox.Show("Сохранить изменения данных для выбраного пользователя?", "Подтвердите действие", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    driver.FirstName = this.textBoxFirstName.Text;
                    driver.SecondName = this.textBoxSecondName.Text;
                    driver.DriverAge = Int32.Parse(this.textBoxAge.Text);
                    driver.CarNum = this.textBoxCarNum.Text;
                    driver.PlaceNum = Int32.Parse(this.textBoxPlaceNum.Text);
                    driver.DriverPhoto = Ph;

                    context.SaveChanges();
                    MessageBox.Show("Изменения сохранены успешно");
                    panelAdmin.Enabled = false;
                    panelAdmin.Visible = false;
                    buttonUpdateAndSave.Visible = false;
                    cleanTextBoxes();
                    panelPhotoThumbnail.Hide();
                    panelStockPhoto.Show();
                }
                    else if (dr == DialogResult.No)
                    {
                    //не сохранять
                    panelAdmin.Enabled = false;
                    panelAdmin.Visible = false;
                    buttonUpdateAndSave.Visible = false;
                    }
               
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}

