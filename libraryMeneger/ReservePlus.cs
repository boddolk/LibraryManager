using libraryMeneger.book;
using libraryMeneger.Data.BookRepository;
using libraryMeneger.Data.StatusRepository;
using libraryMeneger.user;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace libraryMeneger
{
    public partial class ReservePlus : Form
    {
        RegularUser currentUser;
        BooksRepository repository = new BooksRepository();
        StatusRepository statusRepository = new StatusRepository();

        public ReservePlus(RegularUser user)
        {
            currentUser = user;
            InitializeComponent();
            CurrentDateTimePicker.Value = DateTime.Today;
            CurrentDateTimePicker.CustomFormat = "dd.MM.yyyy";
            CurrentDateTimePicker.Format = DateTimePickerFormat.Custom;

            EndDateTimePicker.Value = CurrentDateTimePicker.Value.AddDays(3);
            EndDateTimePicker.CustomFormat = "dd.MM.yyyy";
            EndDateTimePicker.Format = DateTimePickerFormat.Custom;

            List<GenBook> allBooks = repository.getAvailableBooksForBooking();
            if (allBooks.Count > 0)
            {
               BookComboBox.Items.Insert(0, "Select the book:");
                for (int i = 0; i < allBooks.Count; i++) 
                {
                    BookComboBox.Items.Insert(i+1, allBooks[i].BookToString());
                }
            }
            else
            {
                BookComboBox.SelectedIndex = 0;
            }

        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            int article;
            //стягувати з комбо бокса книжку
            if (BookComboBox.SelectedIndex != 0)
            {
                article = int.Parse(new string(this.BookComboBox.SelectedItem.ToString().TakeWhile(char.IsDigit).ToArray()));
                    
                    //стягувати дати
                DateTime current = CurrentDateTimePicker.Value;
                DateTime end = EndDateTimePicker.Value;
            
                    //формувати менеджер
                BookStatManager manager =new BookStatManager(article, current, end, true, false);

                    //піхаєм в базу
                statusRepository.addBookWithItsStatus(currentUser.Login, manager);

                    //вихід
                UserForm form = new UserForm(currentUser);
                form.Show();
                this.Close();

            }

           
           

        }
    }
}
