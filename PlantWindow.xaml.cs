using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;


namespace Ergasia_allilepidrasi
{
    /// <summary>
    /// Interaction logic for PlantWindow.xaml
    /// </summary>
    public partial class PlantWindow : Window
    {
        int stage = 0;
        string a, a1, a2, a3, a4, b, b1, b2, b3,  c, c1, c2, c4, d4a, d4b;
        int test;

        private void textBox1_GotFocus(object sender, RoutedEventArgs e)
        {
            if (textBox1.Text == "Or add something else" || textBox1.Text == "ex. 11") {
                textBox1.Text = "";
            }
        }

        private void textBox2_GotFocus(object sender, RoutedEventArgs e)
        {
            if (textBox2.Text == "am") {
                textBox2.Text = "";
                d4b = null;
            }
        }

        int flag = 0;
        

        public PlantWindow()
        {
            InitializeComponent();
            textBox.Text = ("This app gives you the oportunity to plan your day so you can save time, energy and go through your day in the most efficient way possible.Just follow the steps and enjoy your day!");
            textBox.IsReadOnly = true;
            toggleButton.Opacity = 0;
            toggleButton.IsEnabled = false;
            toggleButton1.Opacity = 0;
            toggleButton1.IsEnabled = false;
            toggleButton2.Opacity = 0;
            toggleButton2.IsEnabled = false;
            toggleButton3.Opacity = 0;
            toggleButton3.IsEnabled = false;
            textBox1.Opacity = 0;
            textBox1.IsEnabled = false;
            textBox2.Opacity = 0;
            textBox2.IsEnabled = false;
            

        }
       

        private void button_Click(object sender, RoutedEventArgs e)
        {
            stage++;

            if (stage == 1) {
                textBox.Text = ("Where do you want to go during your day?");
                toggleButton.Opacity = 100;
                toggleButton.IsEnabled = true;
                toggleButton.Content = ("University");
                toggleButton1.Opacity = 100;
                toggleButton1.IsEnabled = true;
                toggleButton1.Content = ("Job");
                toggleButton2.Opacity = 100;
                toggleButton2.IsEnabled = true;
                toggleButton2.Content = ("Gym");
                toggleButton3.Opacity = 100;
                toggleButton3.IsEnabled = true;
                toggleButton3.Content = ("Night out");
                textBox1.Text = ("Or add something else");
                textBox1.Opacity = 100;
                textBox1.IsEnabled = true;
                textBox2.Opacity = 0;
                textBox2.IsEnabled = false;
                button.Content = ("Next Step");
            }

            if (stage == 2) {
                textBox.Text = ("Which mode of transport do you prefer (You may only choose one)?");
                toggleButton.IsChecked = false;
                toggleButton.Opacity = 100;
                toggleButton.IsEnabled = true;
                toggleButton.Content = ("Metro");
                toggleButton1.IsChecked = false;
                toggleButton1.Opacity = 100;
                toggleButton1.IsEnabled = true;
                toggleButton1.Content = ("Bus");
                toggleButton2.IsChecked = false;
                toggleButton2.Opacity = 100;
                toggleButton2.IsEnabled = true;
                toggleButton2.Content = ("Train");
                toggleButton3.IsChecked = false;
                toggleButton3.Opacity = 100;
                toggleButton3.IsEnabled = true;
                toggleButton3.Content = ("Car");
                textBox1.Opacity = 0;
                textBox1.IsEnabled = false;
                textBox2.Opacity = 0;
                textBox2.IsEnabled = false;
                button.Content = ("Next Step");
            }

            if (stage == 3) {
                textBox.Text = ("Will you need any breaks during your day?");
                toggleButton.IsChecked = false;
                toggleButton.Opacity = 100;
                toggleButton.IsEnabled = true;
                toggleButton.Content = ("Yes");
                toggleButton1.IsChecked = false;
                toggleButton1.Opacity = 100;
                toggleButton1.IsEnabled = true;
                toggleButton1.Content = ("No");
                toggleButton2.IsChecked = false;
                toggleButton2.Opacity = 0;
                toggleButton2.IsEnabled = false;
                toggleButton2.Content = ("");
                toggleButton3.IsChecked = false;
                toggleButton3.Opacity = 0;
                toggleButton3.IsEnabled = false;
                toggleButton3.Content = ("");
                textBox1.Text = ("");
                textBox1.Opacity = 0;
                textBox1.IsEnabled = false;
                textBox2.Opacity = 0;
                textBox2.IsEnabled = false;
                button.Content = ("Next Step");
            }
            if (stage == 4) {
                textBox.Text = ("What time do you want to leave your house?");
                toggleButton.Opacity = 0;
                toggleButton.IsEnabled = false;
                toggleButton1.Opacity = 0;
                toggleButton1.IsEnabled = false;
                toggleButton2.Opacity = 0;
                toggleButton2.IsEnabled = false;
                toggleButton3.Opacity = 0;
                toggleButton3.IsEnabled = false;
                textBox1.Opacity = 100;
                textBox1.IsEnabled = true;
                textBox1.Text = ("ex. 11");
                textBox2.Opacity = 100;
                textBox2.IsEnabled = true;
                textBox2.Text = ("am");
                d4b = "am";
                button.Content = ("See results");
            }
            if (stage == 5)
            {
                string results = null;
                textBox1.Opacity = 0;
                textBox1.IsEnabled = false;
                textBox2.Opacity = 0;
                textBox2.IsEnabled = false;
                results = getresults(a, a1, a2, a3, a4, b, b1, b2, b3,  c, c1, c2, c4, d4a, d4b);
                if (flag == 1)
                {
                    button.Content = ("Close");
                    textBox.Text = (results);
                }
                else
                {
                    button.Content = ("Try again");
                    textBox.Text = (results);
                }

                if (flag == 0)
                {
                    stage = 0;
                    a = null; a1 = null; a2 = null; a3 = null; a4 = null; b = null; b1 = null; b2 = null; b3 = null;  c = null; c1 = null; c2 = null; c4 = null; d4a = null; d4b = null;
                }
            }
            if (stage == 6) {
                if (flag == 1)
                {
                        this.Close();
                } 
            }
        }

        public string getresults(string a, string a1, string a2, string a3, string a4, string b, string b1, string b2, string b3,  string c, string c1, string c2, string c4, string d4a, string d4b) {
            if ((a != null || a1 != null || a2 != null || a3 != null || a4 != null) && (b != null || b1 != null || b2 != null || b3 != null ) && d4a != null && d4b != null)
            {
                string result = null;
                Random rnd = new Random();
                string res1 =null;
                int traffic = rnd.Next(1, 5);
                int o = int.Parse(textBox1.Text);
                if (o == 1) { o = 12; }
                else { o = o - 1; }
                if (traffic == 1 && b1 != null && b==null && b2==null && b3==null) {  res1 = "Judging from the traffic of your area, and the bus schedule you need to leave at " + o + ":30. "; }
                if (traffic == 1 && b3 != null && b == null && b2 == null && b1 == null) {  res1 = "Judging from the traffic of your area, you need to leave at " + o + ":30. "; }
                if (traffic == 2 && b1 != null && b == null && b2 == null && b3 == null) {  res1 = "Judging from the traffic of your area, and the bus schedule you need to leave at " + o + ":30. "; }
                if (traffic == 2 && b3 != null && b == null && b2 == null && b1 == null) {  res1 = "Judging from the traffic of your area, you need to leave at " + o + ":30. "; }
                if (traffic == 3 && b1 != null && b == null && b2 == null && b3 == null) {  res1 = "Judging from the traffic of your area, and the bus schedule you need to leave at " + o + ":45. "; }
                if (traffic == 3 && b3 != null && b == null && b2 == null && b1 == null) {  res1 = "Judging from the traffic of your area, you need to leave at " + o + ":45. "; }
                if (traffic == 4 && b1 != null && b == null && b2 == null && b3 == null) {  res1 = "Judging from the traffic of your area, and the bus schedule you need to leave at " + o + ":55. "; }
                if (traffic == 4 && b3 != null && b == null && b2 == null && b1 == null) {  res1 = "Judging from the traffic of your area, you need to leave at " + o + ":55. "; }
                if ((traffic == 1 || traffic == 2) && b != null && b1 == null && b2 == null && b3 == null) {  res1 = "Judging from the schedule of the metro you need to leave at " + o + ":15. "; }
                if ((traffic == 1 || traffic == 2) && b2 != null && b == null && b1 == null && b3 == null) {  res1 = "Judging from the schedule of the train you need to leave at " + o + ":15. "; }
                if ((traffic == 3 || traffic == 4) && b != null && b1 == null && b2 == null && b3 == null) {  res1 = "Judging from the schedule of the metro you need to leave at " + o + ":30. "; }
                if ((traffic == 3 || traffic == 4) && b2 != null && b == null && b1 == null && b3 == null) {  res1 = "Judging from the schedule of the train you need to leave at " + o + ":30. "; }

                
                if (a4 != null) { a4 = "a"; }
                if (a != null) { a = "a"; }
                if (a1 != null) { a1 = "a"; }
                if (a2 != null) { a2 = "a"; }
                if (a3 != null) { a3 = "a"; }
                string aa = a + a1 + a2 + a3 + a4;
                var count = aa.Count(x => x == 'a');
                string res2 = null;
                if (count == 1 && c!=null && c1 == null) { res2 = "Also looking at your programm you have ~3 hours for your break. "; }
                if (count == 2 && c != null && c1 == null) { res2 = "Also looking at your programm you have ~2 hours for your break. "; }
                if (count == 3 && c != null && c1 == null) { res2 = "Also looking at your programm you have ~1 hours for your break. "; }
                if (count == 4 && c != null && c1 == null) { res2 = "Also looking at your programm you have only ~30 minutes for your break. "; }
                if (count == 5 && c != null && c1 == null) { res2 = "Also looking at your programm you have less than 30 minutes for your break. "; }

                
                string res3 = null;
                int[] numbers = new int[4] { 15, 30, 45, 60 };
                Random rd = new Random();
                int randomIndex = rd.Next(0, numbers.Length);
                int t1 = numbers[randomIndex];
                int randomIndex1 = rd.Next(0, 4);
                int t2 = numbers[randomIndex1];
                int randomIndex2 = rd.Next(0, 4);
                int t3 = numbers[randomIndex2];
                int randomIndex3 = rd.Next(0, 4);
                int t4 = numbers[randomIndex3];
                int randomIndex4 = rd.Next(0, 4);
                int t5 = numbers[randomIndex4];

                if (count == 1 ) { res3 = "You need to travel for: "+t1 +" minutes from your first destination to your 2nd. "; }
                if (count == 2) { res3 = "You need to travel for: " + t1 + " minutes from your first destination to your 2nd,and "+t2+" minutes from your 2nd to your last. "; }
                if (count == 3 ) { res3 = "You need to travel for: " + t1 + " minutes from your first destination to your 2nd,  " + t2 + " minutes from your 2nd to your 3rd,and "+t3+" minutes from your 3rd to your last. "; }
                if (count == 4 ) { res3 = "You need to travel for: " + t1 + " minutes from your first destination to your 2nd,  " + t2 + " minutes from your 2nd to your 3rd, " + t3 + " minutes from your 3rd to your 4th,and "+t4+" minutes from your 4th to your last. "; }
                if (count == 5 ) { res3 = "You need to travel for: " + t1 + " minutes from your first destination to your 2nd,  " + t2 + " minutes from your 2nd to your 3rd, " + t3 + " minutes from your 3rd to your 4th,and " + t4 + " minutes from your 4th to your 5th,and "+t5+" minutes from your 5th to your last. "; }


                result = res1 + res3 + res2 +"Have a nice day :)";
                flag = 1;
                return result ;
            }
            else {
                string result;
                result = "Some of your info appear to be incorrect.Plesase try again.";
                toggleButton.IsChecked = false;
                toggleButton1.IsChecked = false;
                toggleButton2.IsChecked = false;
                toggleButton3.IsChecked = false;
                a = null; a1 = null; a2 = null; a3 = null; a4 = null; b = null; b1 = null; b2 = null; b3 = null; c = null; c1 = null; c2 = null; c4 = null; d4a = null; d4b = null;
                flag = 0;
                return result ;
            }
        }

        private void toggleButton_Checked(object sender, RoutedEventArgs e)
        {
            if (stage == 1) { a = toggleButton.Content.ToString(); }
            if (stage == 2) { b = toggleButton.Content.ToString(); toggleButton1.IsChecked = false; toggleButton2.IsChecked = false; toggleButton3.IsChecked = false; b1 = null; b2 = null; b3 = null; }
            if (stage == 3) { c = toggleButton.Content.ToString(); toggleButton1.IsChecked = false; c1 = null; }
        }

        private void toggleButton_Unchecked(object sender, RoutedEventArgs e)
        {
            if (stage == 1) { a = null; }
            if(stage == 2) { b = null; }
            if (stage == 3) { c = null; }
        }

        private void toggleButton1_Unchecked(object sender, RoutedEventArgs e)
        {
            if (stage == 1) { a1 = null; }
            if (stage == 2) { b1 = null; }
            if (stage == 3) { c1 = null; }
        }

        private void toggleButton1_Checked(object sender, RoutedEventArgs e)
        {
            if (stage == 1) { a1 = toggleButton1.Content.ToString(); }
            if (stage == 2) { b1 =  toggleButton1.Content.ToString(); toggleButton.IsChecked = false; toggleButton2.IsChecked = false; toggleButton3.IsChecked = false; b = null; b2 = null; b3 = null; }
            if (stage == 3) { c1 = toggleButton1.Content.ToString(); toggleButton.IsChecked = false; c = null; }
        }

        private void toggleButton2_Unchecked(object sender, RoutedEventArgs e)
                {
                if (stage == 1) { a2 = null; }
                if (stage == 2) { b2 = null; }
                if (stage == 3) { c2 = null; }
        }

        private void toggleButton2_Checked(object sender, RoutedEventArgs e)
        {
            if (stage == 1) { a2 = toggleButton2.Content.ToString(); }
            if (stage == 2) { b2 = toggleButton2.Content.ToString(); toggleButton1.IsChecked = false; toggleButton.IsChecked = false; toggleButton3.IsChecked = false; b1 = null; b = null; b3 = null; }
            if (stage == 3) { c2 = toggleButton.Content.ToString(); }
        }
        private void toggleButton3_Checked(object sender, RoutedEventArgs e)
                {
            if (stage == 1) { a3 = toggleButton3.Content.ToString(); }
            if (stage == 2) { b3 = toggleButton3.Content.ToString(); toggleButton1.IsChecked = false; toggleButton2.IsChecked = false; toggleButton.IsChecked = false; b1 = null; b2 = null; b = null; }

                }

        private void toggleButton3_Unchecked(object sender, RoutedEventArgs e)
        {
            if (stage == 1) { a3 = null; }
            if (stage == 2) { b3 = null; }
        }

         private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (stage == 1)
            {
                if (textBox1.Text != null && textBox1.Text !="" && textBox1.Text != "Or add something else")
                {
                    a4 = textBox1.Text;
                }
            }
            
            

            if (stage == 4)
            {
                string x = textBox1.Text.ToString();

                if (int.TryParse(x, out test))
                {
                    int y = int.Parse(textBox1.Text);
                    if (y > 0 && y < 13)
                    {
                        d4a = textBox1.Text;
                    }
                    else { d4a = null; }
                }
                
            }
        }
        private void textBox2_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (stage == 4)
            {
                if (textBox2.Text == "am" || textBox2.Text == "pm" || textBox2.Text == "AM" || textBox2.Text == "PM" || textBox2.Text == "Am" || textBox2.Text == "Pm")
                {
                    d4b = textBox2.Text;
                }
            }
        }

    }
}
