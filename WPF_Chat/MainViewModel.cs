using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Chat;

public class MainViewModel
{
    public  ObservableCollection<MessageModel> Messages { get; set; }
    public ObservableCollection<ContactModel> Contacts { get; set; }

    public MainViewModel()
    {
        Messages = new ObservableCollection<MessageModel>();
        Contacts = new ObservableCollection<ContactModel>();

        Messages.Add(new MessageModel()
        {
            Username = "Tim Cook",
            UsernameColor = "#409aff",
            Message = "Test",
            imageSource = "./icons/Tim.jpg",
            Time = DateTime.Now,
            FirstMessage = true
        });
        
        Messages.Add(new MessageModel()
        {
            Username = "Steve Jobs",
            UsernameColor =  "#white",
            Message = "Test last",
            Time = DateTime.Now,
            imageSource = "./icons/Steve.jpg",
            FirstMessage = false
        });

        for (int i = 0; i < 3; i++)
        {
            Contacts.Add(new ContactModel()
            {
                Username = "Steve Jobs",
                ImageSource = "./icons/Steve.jpg",
                Messages = Messages
            });
        }
}
}