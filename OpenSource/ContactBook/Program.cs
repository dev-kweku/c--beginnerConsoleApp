using System;

class Contact{
    public string Name {get;set;}
    public string Email {get;set;}
    public string Phone {get;set;}

    public Contact(string name,string email,string phone){
        Name=name;
        Email=email;
        Phone=phone;
    }

}
public ContactBook{
    private List<Contact> contacts;
    public ContactBook(){
        contacts=new List<Contact>
    }

    public void AddContact(Contact contact){
        contacts.Add(contact);
        Console.WriteLine("Contact added successfully")
    }

    public void SearchContent(string name){
        bool found=false;
        foreach(Contact contact in contacts){
            if(contact.Name.Equals(name,StringComparison.OrdinalIgnoreCase)){
                Console.WriteLine("Contact found :");
                Console.WriteLine("Name" + contact.Name);
                Console.WriteLine("Email " +contact.Email);
                Console.WriteLine("Phone " + contact.Phone);
                found=true;
                break;
            }
        }
        if(!found){
            Console.WriteLine("Contact not found!");
        }
    }

    public void UpdateContact(string name){
        bool found=false;
        foreach (Contact contact in contacts){
            if(contact.Name.Equals(name,StringComparison.OrdinalIgnoreCase)){
                Console.WriteLine("Enter new email (leave blank to keep existing ): ");
                string newEmail=Console.ReadLine();
                if(!string.IsNullWhiteSpace(newEmail)){
                    contact.Email=newEmail;
                }
                Console.WriteLine("Enter new phone number (leave blank to keep existing ):");
                string newPhone=Console.ReadLine();
                if(!string.IsNullWhiteSpace(newPhone)){
                    contact.Phone=newPhone;
                }

                Console.WriteLine("Contact update successfully ");
                found=true;
                break;
                
            }
        }
        if(!found){
            Console.WriteLine("Contact not found ")
        }
    }

}