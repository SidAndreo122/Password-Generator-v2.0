using System;

namespace Password_Generator_v2._0
{
    public partial class Form1 : Form
    {
        /* # Version 2.0 - Password Generator
        # Programmer: Sidney Andreano
        # Last modified: 6/6/2024 11:10AM EST
        # --------------------------------------------------------------------------------------------------------------------------------

        # incorporates the random and string modules

                import random
        import string

        # initialized variables to be used for an array
        SetList = ""

        # Input from user 
        passwordQuestion = int (input("Enter password length:"))

        print('''Choose the character sets you want to include: 
            1. Digits (1-9)
            2. Letters(A-Z)
            3. Special Characters(Punctuation Marks)
            4. Exit''')

        while(True):
            choice = int (input("Pick a number to choose what set to include: "))
            if (choice == 1):
                SetList += string.digits
            elif(choice == 2):
                SetList += string.ascii_letters
            elif(choice == 3):
                SetList += string.punctuation
            elif(choice == 4):
                break
            else:
                print("Enter a valid number: ")
        # The array that will store all possible characters 
        s = []

        for i in range(passwordQuestion) :
            randomchar = random.choice(SetList)
            s.append(randomchar)

        # Output
        print("Your password:","".join(random.sample(s, passwordQuestion))) # generates a random sample of a specified length from the provided s list

        # END PROGRAM
        */
        int length = 0;
        Random character = new Random();

        private void passwordGenerator(int passwordLength)
        {
            String allcharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()-+}{][;:,.<>/?";
            String randompassword = "";
            for (int i =0; i < passwordLength; i++)
            {
                int randnum = character.Next(0,allcharacters.Length);
                randompassword += allcharacters[randnum];
            }
            password.Text = randompassword;
        }

        public Form1()
        {
           InitializeComponent();
            passwordlengthslider.Minimum = 5;
            passwordlengthslider.Maximum = 25;
            passwordGenerator(5);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Password Generator");
        }

        private void Copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(password.Text);
        }

        private void passwordlengthslider_Scroll(object sender, EventArgs e)
        {
            passwordlengthlabel.Text = "Password Length: " + passwordlengthslider.Value.ToString();
            length = passwordlengthslider.Value;
            passwordGenerator(length);
        }
    }
}
