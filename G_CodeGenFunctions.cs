using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlueGCodeGenerator
{
    public partial class GlueGCodeGenerator
    {
        private void processCheckboxes(string checkBoxNumber, object sender, EventArgs e)
        {
            switch (checkBoxNumber)
            {
                case "1":
                    checkBox1_CheckedChanged(sender, e);
                    break;
                case "2":
                    checkBox2_CheckedChanged(sender, e);
                    break;
                case "3":
                    checkBox3_CheckedChanged(sender, e);
                    break;
                case "4":
                    checkBox4_CheckedChanged(sender, e);
                    break;
                case "5":
                    checkBox5_CheckedChanged(sender, e);
                    break;
                case "6":
                    checkBox6_CheckedChanged(sender, e);
                    break;
                case "7":
                    checkBox7_CheckedChanged(sender, e);
                    break;
                case "8":
                    checkBox8_CheckedChanged(sender, e);
                    break;
                case "9":
                    checkBox9_CheckedChanged(sender, e);
                    break;
                case "10":
                    checkBox10_CheckedChanged(sender, e);
                    break;
                case "11":
                    checkBox11_CheckedChanged(sender, e);
                    break;
                case "12":
                    checkBox12_CheckedChanged(sender, e);
                    break;
                case "13":
                    checkBox13_CheckedChanged(sender, e);
                    break;
                case "14":
                    checkBox14_CheckedChanged(sender, e);
                    break;
                case "15":
                    checkBox15_CheckedChanged(sender, e);
                    break;
                case "16":
                    checkBox16_CheckedChanged(sender, e);
                    break;
                case "17":
                    checkBox17_CheckedChanged(sender, e);
                    break;
                case "18":
                    checkBox18_CheckedChanged(sender, e);
                    break;
                case "19":
                    checkBox19_CheckedChanged(sender, e);
                    break;
                case "20":
                    checkBox20_CheckedChanged(sender, e);
                    break;
                case "21":
                    checkBox21_CheckedChanged(sender, e);
                    break;
                case "22":
                    checkBox22_CheckedChanged(sender, e);
                    break;
                case "23":
                    checkBox23_CheckedChanged(sender, e);
                    break;
                case "24":
                    checkBox24_CheckedChanged(sender, e);
                    break;
                case "25":
                    checkBox25_CheckedChanged(sender, e);
                    break;
                case "26":
                    checkBox26_CheckedChanged(sender, e);
                    break;
                case "27":
                    checkBox27_CheckedChanged(sender, e);
                    break;
                case "28":
                    checkBox28_CheckedChanged(sender, e);
                    break;
                case "29":
                    checkBox29_CheckedChanged(sender, e);
                    break;
                case "30":
                    checkBox30_CheckedChanged(sender, e);
                    break;
                case "31":
                    checkBox31_CheckedChanged(sender, e);
                    break;
                case "32":
                    checkBox32_CheckedChanged(sender, e);
                    break;
                case "33":
                    checkBox33_CheckedChanged(sender, e);
                    break;
                case "34":
                    checkBox34_CheckedChanged(sender, e);
                    break;
                case "35":
                    checkBox35_CheckedChanged(sender, e);
                    break;
                case "36":
                    checkBox36_CheckedChanged(sender, e);
                    break;
                default:
                    break;
            }
        }

        private void LineGCode(float X, float Y, float Z, int F)
        {
            G_Code += "G4 P900 \n" +     // wait 900ms, this will determine paste amount
                      "G1 X" + X + " Y" + Y + " Z" + (Z + 1) + " F" + F + " \n" +
                      "M106 S0 \n" +
                      "G1 X" + (X + 2) + " Y" + Y + " Z" + (Z + 2) + " \n";
        }

        private void ArcGCode(float X_offset, float Y_offset)
        {
            //MTG_bottoms
        }

        private void DispenseDevice(float Z)
        {
            G_Code += "G1 Z" + Z + "\n" +             // Lowers tip
                      "M106 S255 \n";                 // Starts paste extrusion
        }

        private void RetractDevice(float Z, int F)
        {
            G_Code += "G1 Z" + Z + " F" + F + " \n";  // Lifts tip 
                      //"M106 S0 \n" +                  // Stops paste extrusion
        }

        private void G_CodeStart(float Z, int F)
        {
            G_Code = "G1 Z" + Z + " F" + F + " \n";  // G Code initialization 
        }

        private void G_CodeEnd(float X, float Y, float Z, int F)
        {
            G_Code += "G1 X" + X + " Y" + Y + " Z" + Z + " F" + F + " \n";  // Puts the printer in a position where the table is easily extractable
        }

        private void InitializeDevice(float X, float Y)
        {
            G_Code += "G1 X" + (X - MTG_StepOffsets.MTG_Glue_Step) + " Y" + Y + "\n";
        }
    }
}
