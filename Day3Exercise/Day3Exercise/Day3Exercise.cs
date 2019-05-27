using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day3Exercise
{
    public partial class Day3Exercise : Form
    {
        public Day3Exercise()
        {
            InitializeComponent();
        }
        
        const int size = 1000;
        int[] number = new int[size];
        int index = 0;
        
        private void ShowButton_Click(object sender, EventArgs e)
        {
            string message = "";

            
            for (int index = 0; index < number.Length; index++)
            {
                if (number[index] != 0)
                    message = message + number[index].ToString() + ",  "; 
            }
                        
            showRichTextBox.Text = "The Elements in the array are: " + message;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {

            number[index] = Convert.ToInt32(numberTextBox.Text);
            index++;

            string message = "";

            for (int index = 0; index < number.Length; index++)
            {
                if (number[index] != 0)
                    message = message + "The Element in Index [" + index + "] Are: " + number[index].ToString() + "\n";
            }

            showRichTextBox.Text = message;


        }

        private void ReverseButton_Click(object sender, EventArgs e)
        {
            string message = "";
            string reverse = "";

            for (int index = 0; index < number.Length; index++)
            {
                if (number[index] != 0)
                    message = message + number[index].ToString() + "  ";
            }

            for(int index = number.Length - 1; index >= 0; index--)
            {

                if (number[index] != 0)
                {
                    reverse = reverse + number[index].ToString() + ",   ";
                }
                
            }

            showRichTextBox.Text = "The values store into the array are: " + message + "\nThe values store into the array in reverse are: " + reverse;
            
        }

        private void SumButton_Click(object sender, EventArgs e)
        {
            string message = "";
            int sum = 0;

            for (int index = 0; index < number.Length; index++)
            {
                if (number[index] != 0)
                    message = message + number[index].ToString() + ",  ";
                sum = sum + number[index];
            }

            showRichTextBox.Text = "The values store into the array are: " + message + 
                "\nSum of all elements store in the array is: " + sum.ToString();
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            const int s = 1000;
            int[] copy = new int[s];

            string message = "";
            string message1 = "";
            
            for (int index = 0; index < number.Length; index++)
            {
                if (number[index] != 0)
                    message = message + number[index].ToString() + ",  ";               
            }
            
            for(int index1 = 0; index1 < copy.Length; index1++)
            {
                copy[index1] = number[index1];

                if (copy[index1] != 0)
                    message1 = message1 + copy[index1].ToString() + ",  ";
            }
            showRichTextBox.Text = "The elements stored in the first array are: " + message +
                "\nThe elements copied into the second array are: " + message1;
        }

        private void DuplicateButton_Click(object sender, EventArgs e)
        {
            string message = "";
            string duplicate = "";
            int total = 0;

            for (int index = 0; index < number.Length; index++)
            {
                if (number[index] != 0)
                {
                    message = message + number[index].ToString() + ",  ";

                    for (int index1 = index+1; index1 < number.Length; index1++)
                    {
                        if(number[index] == number[index1])
                        {
                            duplicate = duplicate + number[index].ToString() + ",   ";
                            total = total + 1;
                        }
                    }
                }
            }
                       
            showRichTextBox.Text = "The Elements in the array are: " + message +
                "\nThe duplicate elements are: " + duplicate +
                "\nTotal number of duplicate elements found in the array is:  " + total.ToString();
        }

        private void UniqueButton_Click(object sender, EventArgs e)
        {
            string message = "";            
            string unique = "";
            int[] freq = new int[size];
            int total = 0;

            for (int index = 0; index < number.Length; index++)
            {
                if (number[index] != 0)
                {
                    message = message + number[index].ToString() + ",  ";
                    freq[index] = -1;
                }
            }

            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] != 0)
                {
                  
                    int count = 1;

                    for(int j = i + 1; j < number.Length; j++)
                    {
                        if(number[i] == number[j])
                        {
                            count = count + 1;
                            freq[j] = 0;
                        }
                    }

                    if(freq[i] != 0)
                    {
                        freq[i] = count;
                    }
                }

            }

            for(int i = 0; i < number.Length; i++)
            {
                if (number[i] != 0)
                {
                    if (freq[i] == 1)
                    {
                        unique = unique + number[i].ToString() + ",   ";
                        total++;
                    }
                }
            }
            
            showRichTextBox.Text = "The Elements in the array are: " + message +
                "\nThe unique elements are: " + unique +
                "\nTotal number of unique elements found in the array is:  " + total.ToString();
        }

        private void MinMaxButton_Click(object sender, EventArgs e)
        {
                      
            string message = "";
            int min = number[0];
            int max = number[0];

            for (int index = 0; index < number.Length; index++)
            {
                if (number[index] != 0)
                {
                    message = message + number[index].ToString() + ",  ";

                    if(number[index] > max)
                    {
                        max = number[index];
                    }

                    if(number[index] < min)
                    {
                        min = number[index];
                    }
                }
                    
            }

            showRichTextBox.Text = "The values store into the array are: " + message + 
                "\nMaximum Element is: " + max.ToString() +
                "\nMinimum Element is:  " + min.ToString();
        }

        private void OddEvenButton_Click(object sender, EventArgs e)
        {
           
            string message = "";
            string odd = "";
            string even = "";

            for (int index = 0; index < number.Length; index++)
            {
                if (number[index] != 0)
                {
                    message = message + number[index].ToString() + ",  ";

                    if (number[index] % 2 == 0)
                    {
                        even = even + number[index].ToString() + ",  ";
                    }

                    else
                    {
                        odd = odd + number[index].ToString() + ",  ";
                    }
                }

            }

            showRichTextBox.Text = "The values store into the array are: " + message +
                "\nThe Even elements are: " + even +
                "\nThe Odd elements are:  " + odd;
        }

        private void AscDesButton_Click(object sender, EventArgs e)
        {
            string message = "";
            string ascending = "";
            string descending = "";
            int temp = 0;

            for (int index = 0; index < number.Length; index++)
            {
                if (number[index] != 0)
                {
                    message = message + number[index].ToString() + ",  ";

                    for(int index1 = 0; index1 < number.Length; index1++)
                    {
                        if(number[index1] != 0)
                        {
                            if(number[index1] > number[index])
                            {
                                temp = number[index];
                                number[index] = number[index1];
                                number[index1] = temp;
                            }
                        }
                    }
                }

            }

            for(int index = 0; index < number.Length; index++)
            {
                if(number[index] != 0)
                ascending = ascending + number[index].ToString() + ",  ";
            }

            for (int index = number.Length - 1; index >= 0; index--)
            {
                if(number[index] != 0)
                descending = descending + number[index].ToString() + ",  ";
            }


            showRichTextBox.Text = "The values store into the array are: " + message +
                "\nElements of array in sorted ascending order: " + ascending +
                "\nElements of the array in sorted descending order:  " + descending;
        }

        private void SortButton_Click(object sender, EventArgs e)
        {
                        
            string message = "";
            
            for (int index = 0; index < number.Length; index++)
            {
                if (number[index] != 0)
                    message = message + number[index].ToString() + ",  ";
            }

            string afterinsert = "";

            number[index] = Convert.ToInt32(insertTextBox.Text);
            index++;

            for (int index = 0; index < number.Length; index++)
            {
                if (number[index] != 0)
                   afterinsert = afterinsert + number[index].ToString() + ",   ";
            }


            string sort = "";
            int temp = 0;

            for (int index = 0; index < number.Length; index++)
            {
                if (number[index] != 0)
                {                   
                    for (int index1 = 0; index1 < number.Length; index1++)
                    {
                        if (number[index1] != 0)
                        {
                            if (number[index1] > number[index])
                            {
                                temp = number[index];
                                number[index] = number[index1];
                                number[index1] = temp;
                            }
                        }
                    }
                }

            }

            for (int index = 0; index < number.Length; index++)
            {
                if (number[index] != 0)
                    sort = sort + number[index].ToString() + " ";
            }



            showRichTextBox.Text = "The Elements in the array are: " + message +
                "Number Inserted : " + insertTextBox.Text +
                "\nAfter Insertion the array is: " + afterinsert +
                "\nAfter Insert the sorted array is: " + sort;
           
        }

        private void showRichTextBox_TextChanged(object sender, EventArgs e)
        {
            showRichTextBox.Font = new Font("Times New Roman", 14);
        }
    }
}
