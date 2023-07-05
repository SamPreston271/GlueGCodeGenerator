using Microsoft.VisualBasic;
using static System.Net.Mime.MediaTypeNames;

namespace GlueGCodeGenerator
{
    public partial class GlueGCodeGenerator : Form
    {
        public string G_Code = "";

        public GlueGCodeGenerator()
        {
            InitializeComponent();
            comboBoxProductType.Items.Add("MTG Tops");
            comboBoxProductType.Items.Add("MTG Bottoms");
            //textBoxFilePath.Text = "C:\\Glue_3d_Printer\\test.nc";  // richies
            textBoxFilePath.Text = "C:\\Visual Studio\\GlueGCodeGenerator\\GlueGCodeGenerator\\test.nc"; // home
            G_CodeStart(GCode_Values.Z, GCode_Values.Feedrate);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            switch (comboBoxProductType.Text)
            {
                case "MTG Tops":
                    InitializeDevice(MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Offset);
                    DispenseDevice(MTG_StepOffsets.MTG_6mm_Z_Dispense);
                    LineGCode(MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Offset, 
                              MTG_StepOffsets.MTG_6mm_Z_Dispense, MTG_StepOffsets.MTG_FeedDispense);
                    RetractDevice(MTG_StepOffsets.MTG_6mm_Z_Retract, MTG_StepOffsets.MTG_FeedRetract);
                    break;
                case "MTG Bottoms":
                    InitializeDevice(MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Offset);
                    DispenseDevice(MTG_StepOffsets.MTG_6mm_Z_Dispense);
                    //ArcGCode(wip)
                    RetractDevice(MTG_StepOffsets.MTG_6mm_Z_Retract, MTG_StepOffsets.MTG_FeedRetract);
                    break;
                default:
                    break;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            switch (comboBoxProductType.Text)
            {
                case "MTG Tops":
                    InitializeDevice(MTG_StepOffsets.MTG_X_Step + MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Offset);
                    DispenseDevice(MTG_StepOffsets.MTG_6mm_Z_Dispense);
                    LineGCode(MTG_StepOffsets.MTG_X_Step + MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Offset, 
                              MTG_StepOffsets.MTG_6mm_Z_Dispense, MTG_StepOffsets.MTG_FeedDispense);
                    RetractDevice(MTG_StepOffsets.MTG_6mm_Z_Retract, MTG_StepOffsets.MTG_FeedRetract);
                    break;
                case "MTG Bottoms":
                    InitializeDevice(MTG_StepOffsets.MTG_X_Step + MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Offset);
                    DispenseDevice(MTG_StepOffsets.MTG_6mm_Z_Dispense);
                    //ArcGCode(wip)
                    RetractDevice(MTG_StepOffsets.MTG_6mm_Z_Retract, MTG_StepOffsets.MTG_FeedRetract);
                    break;
                default:
                    break;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            switch (comboBoxProductType.Text)
            {
                case "MTG Tops":
                    InitializeDevice(MTG_StepOffsets.MTG_X_Step * 2 + MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Offset);
                    DispenseDevice(MTG_StepOffsets.MTG_6mm_Z_Dispense);
                    LineGCode(MTG_StepOffsets.MTG_X_Step * 2 + MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Offset,
                              MTG_StepOffsets.MTG_6mm_Z_Dispense, MTG_StepOffsets.MTG_FeedDispense);
                    RetractDevice(MTG_StepOffsets.MTG_6mm_Z_Retract, MTG_StepOffsets.MTG_FeedRetract);
                    break;
                case "MTG Bottoms":
                    InitializeDevice(MTG_StepOffsets.MTG_X_Step * 2 + MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Offset);
                    DispenseDevice(MTG_StepOffsets.MTG_6mm_Z_Dispense);
                    //ArcGCode(wip)
                    RetractDevice(MTG_StepOffsets.MTG_6mm_Z_Retract, MTG_StepOffsets.MTG_FeedRetract);
                    break;
                default:
                    break;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            switch (comboBoxProductType.Text)
            {
                case "MTG Tops":
                    InitializeDevice(MTG_StepOffsets.MTG_X_Step * 3 + MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Offset);
                    DispenseDevice(MTG_StepOffsets.MTG_6mm_Z_Dispense);
                    LineGCode(MTG_StepOffsets.MTG_X_Step * 3 + MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Offset,
                              MTG_StepOffsets.MTG_6mm_Z_Dispense, MTG_StepOffsets.MTG_FeedDispense);
                    RetractDevice(MTG_StepOffsets.MTG_6mm_Z_Retract, MTG_StepOffsets.MTG_FeedRetract);
                    break;
                case "MTG Bottoms":
                    InitializeDevice(MTG_StepOffsets.MTG_X_Step * 3 + MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Offset);
                    DispenseDevice(MTG_StepOffsets.MTG_6mm_Z_Dispense);
                    //ArcGCode(wip)
                    RetractDevice(MTG_StepOffsets.MTG_6mm_Z_Retract, MTG_StepOffsets.MTG_FeedRetract);
                    break;
                default:
                    break;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            switch (comboBoxProductType.Text)
            {
                case "MTG Tops":
                    InitializeDevice(MTG_StepOffsets.MTG_X_Step * 4 + MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Offset);
                    DispenseDevice(MTG_StepOffsets.MTG_6mm_Z_Dispense);
                    LineGCode(MTG_StepOffsets.MTG_X_Step * 4 + MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Offset,
                              MTG_StepOffsets.MTG_6mm_Z_Dispense, MTG_StepOffsets.MTG_FeedDispense);
                    RetractDevice(MTG_StepOffsets.MTG_6mm_Z_Retract, MTG_StepOffsets.MTG_FeedRetract);
                    break;
                case "MTG Bottoms":
                    InitializeDevice(MTG_StepOffsets.MTG_X_Step * 4 + MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Offset);
                    DispenseDevice(MTG_StepOffsets.MTG_6mm_Z_Dispense);
                    //ArcGCode(wip)
                    RetractDevice(MTG_StepOffsets.MTG_6mm_Z_Retract, MTG_StepOffsets.MTG_FeedRetract);
                    break;
                default:
                    break;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            switch (comboBoxProductType.Text)
            {
                case "MTG Tops":
                    InitializeDevice(MTG_StepOffsets.MTG_X_Step * 5 + MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Offset);
                    DispenseDevice(MTG_StepOffsets.MTG_6mm_Z_Dispense);
                    LineGCode(MTG_StepOffsets.MTG_X_Step * 5 + MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Offset,
                              MTG_StepOffsets.MTG_6mm_Z_Dispense, MTG_StepOffsets.MTG_FeedDispense);
                    RetractDevice(MTG_StepOffsets.MTG_6mm_Z_Retract, MTG_StepOffsets.MTG_FeedRetract);
                    break;
                case "MTG Bottoms":
                    InitializeDevice(MTG_StepOffsets.MTG_X_Step * 5 + MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Offset);
                    DispenseDevice(MTG_StepOffsets.MTG_6mm_Z_Dispense);
                    //ArcGCode(wip)
                    RetractDevice(MTG_StepOffsets.MTG_6mm_Z_Retract, MTG_StepOffsets.MTG_FeedRetract);
                    break;
                default:
                    break;
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            switch (comboBoxProductType.Text)
            {
                case "MTG Tops":
                    InitializeDevice(MTG_StepOffsets.MTG_X_Step * 5 + MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Step + MTG_StepOffsets.MTG_Y_Offset);
                    DispenseDevice(MTG_StepOffsets.MTG_6mm_Z_Dispense);
                    LineGCode(MTG_StepOffsets.MTG_X_Step * 5 + MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Step + MTG_StepOffsets.MTG_Y_Offset,
                              MTG_StepOffsets.MTG_6mm_Z_Dispense, MTG_StepOffsets.MTG_FeedDispense);
                    RetractDevice(MTG_StepOffsets.MTG_6mm_Z_Retract, MTG_StepOffsets.MTG_FeedRetract);
                    break;
                case "MTG Bottoms":
                    InitializeDevice(MTG_StepOffsets.MTG_X_Step * 5 + MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Step + MTG_StepOffsets.MTG_Y_Offset);
                    DispenseDevice(MTG_StepOffsets.MTG_6mm_Z_Dispense);
                    //ArcGCode(wip)
                    RetractDevice(MTG_StepOffsets.MTG_6mm_Z_Retract, MTG_StepOffsets.MTG_FeedRetract);
                    break;
                default:
                    break;
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            switch (comboBoxProductType.Text)
            {
                case "MTG Tops":
                    InitializeDevice(MTG_StepOffsets.MTG_X_Step * 4 + MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Step + MTG_StepOffsets.MTG_Y_Offset);
                    DispenseDevice(MTG_StepOffsets.MTG_6mm_Z_Dispense);
                    LineGCode(MTG_StepOffsets.MTG_X_Step * 4 + MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Step + MTG_StepOffsets.MTG_Y_Offset,
                              MTG_StepOffsets.MTG_6mm_Z_Dispense, MTG_StepOffsets.MTG_FeedDispense);
                    RetractDevice(MTG_StepOffsets.MTG_6mm_Z_Retract, MTG_StepOffsets.MTG_FeedRetract);
                    break;
                case "MTG Bottoms":
                    InitializeDevice(MTG_StepOffsets.MTG_X_Step * 4 + MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Step + MTG_StepOffsets.MTG_Y_Offset);
                    DispenseDevice(MTG_StepOffsets.MTG_6mm_Z_Dispense);
                    //ArcGCode(wip)
                    RetractDevice(MTG_StepOffsets.MTG_6mm_Z_Retract, MTG_StepOffsets.MTG_FeedRetract);
                    break;
                default:
                    break;
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            switch (comboBoxProductType.Text)
            {
                case "MTG Tops":
                    InitializeDevice(MTG_StepOffsets.MTG_X_Step * 3 + MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Step + MTG_StepOffsets.MTG_Y_Offset);
                    DispenseDevice(MTG_StepOffsets.MTG_6mm_Z_Dispense);
                    LineGCode(MTG_StepOffsets.MTG_X_Step * 3 + MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Step + MTG_StepOffsets.MTG_Y_Offset,
                              MTG_StepOffsets.MTG_6mm_Z_Dispense, MTG_StepOffsets.MTG_FeedDispense);
                    RetractDevice(MTG_StepOffsets.MTG_6mm_Z_Retract, MTG_StepOffsets.MTG_FeedRetract);
                    break;
                case "MTG Bottoms":
                    InitializeDevice(MTG_StepOffsets.MTG_X_Step * 3 + MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Step + MTG_StepOffsets.MTG_Y_Offset);
                    DispenseDevice(MTG_StepOffsets.MTG_6mm_Z_Dispense);
                    //ArcGCode(wip)
                    RetractDevice(MTG_StepOffsets.MTG_6mm_Z_Retract, MTG_StepOffsets.MTG_FeedRetract);
                    break;
                default:
                    break;
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            switch (comboBoxProductType.Text)
            {
                case "MTG Tops":
                    InitializeDevice(MTG_StepOffsets.MTG_X_Step * 2 + MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Step + MTG_StepOffsets.MTG_Y_Offset);
                    DispenseDevice(MTG_StepOffsets.MTG_6mm_Z_Dispense);
                    LineGCode(MTG_StepOffsets.MTG_X_Step * 2 + MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Step + MTG_StepOffsets.MTG_Y_Offset,
                              MTG_StepOffsets.MTG_6mm_Z_Dispense, MTG_StepOffsets.MTG_FeedDispense);
                    RetractDevice(MTG_StepOffsets.MTG_6mm_Z_Retract, MTG_StepOffsets.MTG_FeedRetract);
                    break;
                case "MTG Bottoms":
                    InitializeDevice(MTG_StepOffsets.MTG_X_Step * 2 + MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Step + MTG_StepOffsets.MTG_Y_Offset);
                    DispenseDevice(MTG_StepOffsets.MTG_6mm_Z_Dispense);
                    //ArcGCode(wip)
                    RetractDevice(MTG_StepOffsets.MTG_6mm_Z_Retract, MTG_StepOffsets.MTG_FeedRetract);
                    break;
                default:
                    break;
            }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            switch (comboBoxProductType.Text)
            {
                case "MTG Tops":
                    InitializeDevice(MTG_StepOffsets.MTG_X_Step + MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Step + MTG_StepOffsets.MTG_Y_Offset);
                    DispenseDevice(MTG_StepOffsets.MTG_6mm_Z_Dispense);
                    LineGCode(MTG_StepOffsets.MTG_X_Step + MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Step + MTG_StepOffsets.MTG_Y_Offset,
                              MTG_StepOffsets.MTG_6mm_Z_Dispense, MTG_StepOffsets.MTG_FeedDispense);
                    RetractDevice(MTG_StepOffsets.MTG_6mm_Z_Retract, MTG_StepOffsets.MTG_FeedRetract);
                    break;
                case "MTG Bottoms":
                    InitializeDevice(MTG_StepOffsets.MTG_X_Step + MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Step + MTG_StepOffsets.MTG_Y_Offset);
                    DispenseDevice(MTG_StepOffsets.MTG_6mm_Z_Dispense);
                    //ArcGCode(wip)
                    RetractDevice(MTG_StepOffsets.MTG_6mm_Z_Retract, MTG_StepOffsets.MTG_FeedRetract);
                    break;
                default:
                    break;
            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            switch (comboBoxProductType.Text)
            {
                case "MTG Tops":
                    InitializeDevice(MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Step + MTG_StepOffsets.MTG_Y_Offset);
                    DispenseDevice(MTG_StepOffsets.MTG_6mm_Z_Dispense);
                    LineGCode(MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Step + MTG_StepOffsets.MTG_Y_Offset,
                              MTG_StepOffsets.MTG_6mm_Z_Dispense, MTG_StepOffsets.MTG_FeedDispense);
                    RetractDevice(MTG_StepOffsets.MTG_6mm_Z_Retract, MTG_StepOffsets.MTG_FeedRetract);
                    break;
                case "MTG Bottoms":
                    InitializeDevice(MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Step + MTG_StepOffsets.MTG_Y_Offset);
                    DispenseDevice(MTG_StepOffsets.MTG_6mm_Z_Dispense);
                    //ArcGCode(wip)
                    RetractDevice(MTG_StepOffsets.MTG_6mm_Z_Retract, MTG_StepOffsets.MTG_FeedRetract);
                    break;
                default:
                    break;
            }
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            switch (comboBoxProductType.Text)
            {
                case "MTG Tops":
                    InitializeDevice(MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Step * 2 + MTG_StepOffsets.MTG_Y_Offset);
                    DispenseDevice(MTG_StepOffsets.MTG_6mm_Z_Dispense);
                    LineGCode(MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Step * 2 + MTG_StepOffsets.MTG_Y_Offset,
                              MTG_StepOffsets.MTG_6mm_Z_Dispense, MTG_StepOffsets.MTG_FeedDispense);
                    RetractDevice(MTG_StepOffsets.MTG_6mm_Z_Retract, MTG_StepOffsets.MTG_FeedRetract);
                    break;
                case "MTG Bottoms":
                    InitializeDevice(MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Step * 2 + MTG_StepOffsets.MTG_Y_Offset);
                    DispenseDevice(MTG_StepOffsets.MTG_6mm_Z_Dispense);
                    //ArcGCode(wip)
                    RetractDevice(MTG_StepOffsets.MTG_6mm_Z_Retract, MTG_StepOffsets.MTG_FeedRetract);
                    break;
                default:
                    break;
            }
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            switch (comboBoxProductType.Text)
            {
                case "MTG Tops":
                    InitializeDevice(MTG_StepOffsets.MTG_X_Step + MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Step * 2 + MTG_StepOffsets.MTG_Y_Offset);
                    DispenseDevice(MTG_StepOffsets.MTG_6mm_Z_Dispense);
                    LineGCode(MTG_StepOffsets.MTG_X_Step + MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Step * 2 + MTG_StepOffsets.MTG_Y_Offset,
                              MTG_StepOffsets.MTG_6mm_Z_Dispense, MTG_StepOffsets.MTG_FeedDispense);
                    RetractDevice(MTG_StepOffsets.MTG_6mm_Z_Retract, MTG_StepOffsets.MTG_FeedRetract);
                    break;
                case "MTG Bottoms":
                    InitializeDevice(MTG_StepOffsets.MTG_X_Step + MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Step * 2 + MTG_StepOffsets.MTG_Y_Offset);
                    DispenseDevice(MTG_StepOffsets.MTG_6mm_Z_Dispense);
                    //ArcGCode(wip)
                    RetractDevice(MTG_StepOffsets.MTG_6mm_Z_Retract, MTG_StepOffsets.MTG_FeedRetract);
                    break;
                default:
                    break;
            }
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            switch (comboBoxProductType.Text)
            {
                case "MTG Tops":
                    InitializeDevice(MTG_StepOffsets.MTG_X_Step * 2 + MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Step * 2 + MTG_StepOffsets.MTG_Y_Offset);
                    DispenseDevice(MTG_StepOffsets.MTG_6mm_Z_Dispense);
                    LineGCode(MTG_StepOffsets.MTG_X_Step * 2 + MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Step * 2 + MTG_StepOffsets.MTG_Y_Offset,
                              MTG_StepOffsets.MTG_6mm_Z_Dispense, MTG_StepOffsets.MTG_FeedDispense);
                    RetractDevice(MTG_StepOffsets.MTG_6mm_Z_Retract, MTG_StepOffsets.MTG_FeedRetract);
                    break;
                case "MTG Bottoms":
                    InitializeDevice(MTG_StepOffsets.MTG_X_Step * 2 + MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Step * 2 + MTG_StepOffsets.MTG_Y_Offset);
                    DispenseDevice(MTG_StepOffsets.MTG_6mm_Z_Dispense);
                    //ArcGCode(wip)
                    RetractDevice(MTG_StepOffsets.MTG_6mm_Z_Retract, MTG_StepOffsets.MTG_FeedRetract);
                    break;
                default:
                    break;
            }
        }
        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            switch (comboBoxProductType.Text)
            {
                case "MTG Tops":
                    InitializeDevice(MTG_StepOffsets.MTG_X_Step * 3 + MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Step * 2 + MTG_StepOffsets.MTG_Y_Offset);
                    DispenseDevice(MTG_StepOffsets.MTG_6mm_Z_Dispense);
                    LineGCode(MTG_StepOffsets.MTG_X_Step * 3 + MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Step * 2 + MTG_StepOffsets.MTG_Y_Offset,
                              MTG_StepOffsets.MTG_6mm_Z_Dispense, MTG_StepOffsets.MTG_FeedDispense);
                    RetractDevice(MTG_StepOffsets.MTG_6mm_Z_Retract, MTG_StepOffsets.MTG_FeedRetract);
                    break;
                case "MTG Bottoms":
                    InitializeDevice(MTG_StepOffsets.MTG_X_Step * 3 + MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Step * 2 + MTG_StepOffsets.MTG_Y_Offset);
                    DispenseDevice(MTG_StepOffsets.MTG_6mm_Z_Dispense);
                    //ArcGCode(wip)
                    RetractDevice(MTG_StepOffsets.MTG_6mm_Z_Retract, MTG_StepOffsets.MTG_FeedRetract);
                    break;
                default:
                    break;
            }
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            switch (comboBoxProductType.Text)
            {
                case "MTG Tops":
                    InitializeDevice(MTG_StepOffsets.MTG_X_Step * 4 + MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Step * 2 + MTG_StepOffsets.MTG_Y_Offset);
                    DispenseDevice(MTG_StepOffsets.MTG_6mm_Z_Dispense);
                    LineGCode(MTG_StepOffsets.MTG_X_Step * 4 + MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Step * 2 + MTG_StepOffsets.MTG_Y_Offset,
                              MTG_StepOffsets.MTG_6mm_Z_Dispense, MTG_StepOffsets.MTG_FeedDispense);
                    RetractDevice(MTG_StepOffsets.MTG_6mm_Z_Retract, MTG_StepOffsets.MTG_FeedRetract);
                    break;
                case "MTG Bottoms":
                    InitializeDevice(MTG_StepOffsets.MTG_X_Step * 4 + MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Step * 2 + MTG_StepOffsets.MTG_Y_Offset);
                    DispenseDevice(MTG_StepOffsets.MTG_6mm_Z_Dispense);
                    //ArcGCode(wip)
                    RetractDevice(MTG_StepOffsets.MTG_6mm_Z_Retract, MTG_StepOffsets.MTG_FeedRetract);
                    break;
                default:
                    break;
            }
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            switch (comboBoxProductType.Text)
            {
                case "MTG Tops":
                    InitializeDevice(MTG_StepOffsets.MTG_X_Step * 5 + MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Step * 2 + MTG_StepOffsets.MTG_Y_Offset);
                    DispenseDevice(MTG_StepOffsets.MTG_6mm_Z_Dispense);
                    LineGCode(MTG_StepOffsets.MTG_X_Step * 5 + MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Step * 2 + MTG_StepOffsets.MTG_Y_Offset,
                              MTG_StepOffsets.MTG_6mm_Z_Dispense, MTG_StepOffsets.MTG_FeedDispense);
                    RetractDevice(MTG_StepOffsets.MTG_6mm_Z_Retract, MTG_StepOffsets.MTG_FeedRetract);
                    break;
                case "MTG Bottoms":
                    InitializeDevice(MTG_StepOffsets.MTG_X_Step * 5 + MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Step * 2 + MTG_StepOffsets.MTG_Y_Offset);
                    DispenseDevice(MTG_StepOffsets.MTG_6mm_Z_Dispense);
                    //ArcGCode(wip)
                    RetractDevice(MTG_StepOffsets.MTG_6mm_Z_Retract, MTG_StepOffsets.MTG_FeedRetract);
                    break;
                default:
                    break;
            }
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            switch (comboBoxProductType.Text)
            {
                case "MTG Tops":
                    InitializeDevice(MTG_StepOffsets.MTG_X_Step * 5 + MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Step * 3 + MTG_StepOffsets.MTG_Y_Offset);
                    DispenseDevice(MTG_StepOffsets.MTG_6mm_Z_Dispense);
                    LineGCode(MTG_StepOffsets.MTG_X_Step * 5 + MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Step * 3 + MTG_StepOffsets.MTG_Y_Offset,
                              MTG_StepOffsets.MTG_6mm_Z_Dispense, MTG_StepOffsets.MTG_FeedDispense);
                    RetractDevice(MTG_StepOffsets.MTG_6mm_Z_Retract, MTG_StepOffsets.MTG_FeedRetract);
                    break;
                case "MTG Bottoms":
                    InitializeDevice(MTG_StepOffsets.MTG_X_Step * 5 + MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Step * 3 + MTG_StepOffsets.MTG_Y_Offset);
                    DispenseDevice(MTG_StepOffsets.MTG_6mm_Z_Dispense);
                    //ArcGCode(wip)
                    RetractDevice(MTG_StepOffsets.MTG_6mm_Z_Retract, MTG_StepOffsets.MTG_FeedRetract);
                    break;
                default:
                    break;
            }
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            switch (comboBoxProductType.Text)
            {
                case "MTG Tops":
                    InitializeDevice(MTG_StepOffsets.MTG_X_Step * 4 + MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Step * 3 + MTG_StepOffsets.MTG_Y_Offset);
                    DispenseDevice(MTG_StepOffsets.MTG_6mm_Z_Dispense);
                    LineGCode(MTG_StepOffsets.MTG_X_Step * 4 + MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Step * 3 + MTG_StepOffsets.MTG_Y_Offset,
                              MTG_StepOffsets.MTG_6mm_Z_Dispense, MTG_StepOffsets.MTG_FeedDispense);
                    RetractDevice(MTG_StepOffsets.MTG_6mm_Z_Retract, MTG_StepOffsets.MTG_FeedRetract);
                    break;
                case "MTG Bottoms":
                    InitializeDevice(MTG_StepOffsets.MTG_X_Step * 4 + MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Step * 3 + MTG_StepOffsets.MTG_Y_Offset);
                    DispenseDevice(MTG_StepOffsets.MTG_6mm_Z_Dispense);
                    //ArcGCode(wip)
                    RetractDevice(MTG_StepOffsets.MTG_6mm_Z_Retract, MTG_StepOffsets.MTG_FeedRetract);
                    break;
                default:
                    break;
            }
        }

        private void checkBox21_CheckedChanged(object sender, EventArgs e)
        {
            switch (comboBoxProductType.Text)
            {
                case "MTG Tops":
                    InitializeDevice(MTG_StepOffsets.MTG_X_Step * 3 + MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Step * 3 + MTG_StepOffsets.MTG_Y_Offset);
                    DispenseDevice(MTG_StepOffsets.MTG_6mm_Z_Dispense);
                    LineGCode(MTG_StepOffsets.MTG_X_Step * 3 + MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Step * 3 + MTG_StepOffsets.MTG_Y_Offset,
                              MTG_StepOffsets.MTG_6mm_Z_Dispense, MTG_StepOffsets.MTG_FeedDispense);
                    RetractDevice(MTG_StepOffsets.MTG_6mm_Z_Retract, MTG_StepOffsets.MTG_FeedRetract);
                    break;
                case "MTG Bottoms":
                    InitializeDevice(MTG_StepOffsets.MTG_X_Step * 3 + MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Step * 3 + MTG_StepOffsets.MTG_Y_Offset);
                    DispenseDevice(MTG_StepOffsets.MTG_6mm_Z_Dispense);
                    //ArcGCode(wip)
                    RetractDevice(MTG_StepOffsets.MTG_6mm_Z_Retract, MTG_StepOffsets.MTG_FeedRetract);
                    break;
                default:
                    break;
            }
        }

        private void checkBox22_CheckedChanged(object sender, EventArgs e)
        {
            switch (comboBoxProductType.Text)
            {
                case "MTG Tops":
                    InitializeDevice(MTG_StepOffsets.MTG_X_Step * 2 + MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Step * 3 + MTG_StepOffsets.MTG_Y_Offset);
                    DispenseDevice(MTG_StepOffsets.MTG_6mm_Z_Dispense);
                    LineGCode(MTG_StepOffsets.MTG_X_Step * 2 + MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Step * 3 + MTG_StepOffsets.MTG_Y_Offset,
                              MTG_StepOffsets.MTG_6mm_Z_Dispense, MTG_StepOffsets.MTG_FeedDispense);
                    RetractDevice(MTG_StepOffsets.MTG_6mm_Z_Retract, MTG_StepOffsets.MTG_FeedRetract);
                    break;
                case "MTG Bottoms":
                    InitializeDevice(MTG_StepOffsets.MTG_X_Step * 2 + MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Step * 3 + MTG_StepOffsets.MTG_Y_Offset);
                    DispenseDevice(MTG_StepOffsets.MTG_6mm_Z_Dispense);
                    //ArcGCode(wip)
                    RetractDevice(MTG_StepOffsets.MTG_6mm_Z_Retract, MTG_StepOffsets.MTG_FeedRetract);
                    break;
                default:
                    break;
            }
        }

        private void checkBox23_CheckedChanged(object sender, EventArgs e)
        {
            switch (comboBoxProductType.Text)
            {
                case "MTG Tops":
                    InitializeDevice(MTG_StepOffsets.MTG_X_Step + MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Step * 3 + MTG_StepOffsets.MTG_Y_Offset);
                    DispenseDevice(MTG_StepOffsets.MTG_6mm_Z_Dispense);
                    LineGCode(MTG_StepOffsets.MTG_X_Step + MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Step * 3 + MTG_StepOffsets.MTG_Y_Offset,
                              MTG_StepOffsets.MTG_6mm_Z_Dispense, MTG_StepOffsets.MTG_FeedDispense);
                    RetractDevice(MTG_StepOffsets.MTG_6mm_Z_Retract, MTG_StepOffsets.MTG_FeedRetract);
                    break;
                case "MTG Bottoms":
                    InitializeDevice(MTG_StepOffsets.MTG_X_Step + MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Step * 3 + MTG_StepOffsets.MTG_Y_Offset);
                    DispenseDevice(MTG_StepOffsets.MTG_6mm_Z_Dispense);
                    //ArcGCode(wip)
                    RetractDevice(MTG_StepOffsets.MTG_6mm_Z_Retract, MTG_StepOffsets.MTG_FeedRetract);
                    break;
                default:
                    break;
            }
        }

        private void checkBox24_CheckedChanged(object sender, EventArgs e)
        {
            switch (comboBoxProductType.Text)
            {
                case "MTG Tops":
                    InitializeDevice(MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Step * 3 + MTG_StepOffsets.MTG_Y_Offset);
                    DispenseDevice(MTG_StepOffsets.MTG_6mm_Z_Dispense);
                    LineGCode(MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Step * 3 + MTG_StepOffsets.MTG_Y_Offset,
                              MTG_StepOffsets.MTG_6mm_Z_Dispense, MTG_StepOffsets.MTG_FeedDispense);
                    RetractDevice(MTG_StepOffsets.MTG_6mm_Z_Retract, MTG_StepOffsets.MTG_FeedRetract);
                    break;
                case "MTG Bottoms":
                    InitializeDevice(MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Step * 3 + MTG_StepOffsets.MTG_Y_Offset);
                    DispenseDevice(MTG_StepOffsets.MTG_6mm_Z_Dispense);
                    //ArcGCode(wip)
                    RetractDevice(MTG_StepOffsets.MTG_6mm_Z_Retract, MTG_StepOffsets.MTG_FeedRetract);
                    break;
                default:
                    break;
            }
        }

        private void checkBox25_CheckedChanged(object sender, EventArgs e)
        {
            switch (comboBoxProductType.Text)
            {
                case "MTG Tops":
                    InitializeDevice(MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Step * 4 + MTG_StepOffsets.MTG_Y_Offset);
                    DispenseDevice(MTG_StepOffsets.MTG_6mm_Z_Dispense);
                    LineGCode(MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Step * 4 + MTG_StepOffsets.MTG_Y_Offset,
                              MTG_StepOffsets.MTG_6mm_Z_Dispense, MTG_StepOffsets.MTG_FeedDispense);
                    RetractDevice(MTG_StepOffsets.MTG_6mm_Z_Retract, MTG_StepOffsets.MTG_FeedRetract);
                    break;
                case "MTG Bottoms":
                    InitializeDevice(MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Step * 4 + MTG_StepOffsets.MTG_Y_Offset);
                    DispenseDevice(MTG_StepOffsets.MTG_6mm_Z_Dispense);
                    //ArcGCode(wip)
                    RetractDevice(MTG_StepOffsets.MTG_6mm_Z_Retract, MTG_StepOffsets.MTG_FeedRetract);
                    break;
                default:
                    break;
            }
        }

        private void checkBox26_CheckedChanged(object sender, EventArgs e)
        {
            switch (comboBoxProductType.Text)
            {
                case "MTG Tops":
                    InitializeDevice(MTG_StepOffsets.MTG_X_Step + MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Step * 4 + MTG_StepOffsets.MTG_Y_Offset);
                    DispenseDevice(MTG_StepOffsets.MTG_6mm_Z_Dispense);
                    LineGCode(MTG_StepOffsets.MTG_X_Step + MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Step * 4 + MTG_StepOffsets.MTG_Y_Offset,
                              MTG_StepOffsets.MTG_6mm_Z_Dispense, MTG_StepOffsets.MTG_FeedDispense);
                    RetractDevice(MTG_StepOffsets.MTG_6mm_Z_Retract, MTG_StepOffsets.MTG_FeedRetract);
                    break;
                case "MTG Bottoms":
                    InitializeDevice(MTG_StepOffsets.MTG_X_Step + MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Step * 4 + MTG_StepOffsets.MTG_Y_Offset);
                    DispenseDevice(MTG_StepOffsets.MTG_6mm_Z_Dispense);
                    //ArcGCode(wip)
                    RetractDevice(MTG_StepOffsets.MTG_6mm_Z_Retract, MTG_StepOffsets.MTG_FeedRetract);
                    break;
                default:
                    break;
            }
        }

        private void checkBox27_CheckedChanged(object sender, EventArgs e)
        {
            switch (comboBoxProductType.Text)
            {
                case "MTG Tops":
                    InitializeDevice(MTG_StepOffsets.MTG_X_Step * 2 + MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Step * 4 + MTG_StepOffsets.MTG_Y_Offset);
                    DispenseDevice(MTG_StepOffsets.MTG_6mm_Z_Dispense);
                    LineGCode(MTG_StepOffsets.MTG_X_Step * 2 + MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Step * 4 + MTG_StepOffsets.MTG_Y_Offset,
                              MTG_StepOffsets.MTG_6mm_Z_Dispense, MTG_StepOffsets.MTG_FeedDispense);
                    RetractDevice(MTG_StepOffsets.MTG_6mm_Z_Retract, MTG_StepOffsets.MTG_FeedRetract);
                    break;
                case "MTG Bottoms":
                    InitializeDevice(MTG_StepOffsets.MTG_X_Step * 2 + MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Step * 4 + MTG_StepOffsets.MTG_Y_Offset);
                    DispenseDevice(MTG_StepOffsets.MTG_6mm_Z_Dispense);
                    //ArcGCode(wip)
                    RetractDevice(MTG_StepOffsets.MTG_6mm_Z_Retract, MTG_StepOffsets.MTG_FeedRetract);
                    break;
                default:
                    break;
            }
        }

        private void checkBox28_CheckedChanged(object sender, EventArgs e)
        {
            switch (comboBoxProductType.Text)
            {
                case "MTG Tops":
                    InitializeDevice(MTG_StepOffsets.MTG_X_Step * 3 + MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Step * 4 + MTG_StepOffsets.MTG_Y_Offset);
                    DispenseDevice(MTG_StepOffsets.MTG_6mm_Z_Dispense);
                    LineGCode(MTG_StepOffsets.MTG_X_Step * 3 + MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Step * 4 + MTG_StepOffsets.MTG_Y_Offset,
                              MTG_StepOffsets.MTG_6mm_Z_Dispense, MTG_StepOffsets.MTG_FeedDispense);
                    RetractDevice(MTG_StepOffsets.MTG_6mm_Z_Retract, MTG_StepOffsets.MTG_FeedRetract);
                    break;
                case "MTG Bottoms":
                    InitializeDevice(MTG_StepOffsets.MTG_X_Step * 3 + MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Step * 4 + MTG_StepOffsets.MTG_Y_Offset);
                    DispenseDevice(MTG_StepOffsets.MTG_6mm_Z_Dispense);
                    //ArcGCode(wip)
                    RetractDevice(MTG_StepOffsets.MTG_6mm_Z_Retract, MTG_StepOffsets.MTG_FeedRetract);
                    break;
                default:
                    break;
            }
        }

        private void checkBox29_CheckedChanged(object sender, EventArgs e)
        {
            switch (comboBoxProductType.Text)
            {
                case "MTG Tops":
                    InitializeDevice(MTG_StepOffsets.MTG_X_Step * 4 + MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Step * 4 + MTG_StepOffsets.MTG_Y_Offset);
                    DispenseDevice(MTG_StepOffsets.MTG_6mm_Z_Dispense);
                    LineGCode(MTG_StepOffsets.MTG_X_Step * 4 + MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Step * 4 + MTG_StepOffsets.MTG_Y_Offset,
                              MTG_StepOffsets.MTG_6mm_Z_Dispense, MTG_StepOffsets.MTG_FeedDispense);
                    RetractDevice(MTG_StepOffsets.MTG_6mm_Z_Retract, MTG_StepOffsets.MTG_FeedRetract);
                    break;
                case "MTG Bottoms":
                    InitializeDevice(MTG_StepOffsets.MTG_X_Step * 4 + MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Step * 4 + MTG_StepOffsets.MTG_Y_Offset);
                    DispenseDevice(MTG_StepOffsets.MTG_6mm_Z_Dispense);
                    //ArcGCode(wip)
                    RetractDevice(MTG_StepOffsets.MTG_6mm_Z_Retract, MTG_StepOffsets.MTG_FeedRetract);
                    break;
                default:
                    break;
            }
        }

        private void checkBox30_CheckedChanged(object sender, EventArgs e)
        {
            switch (comboBoxProductType.Text)
            {
                case "MTG Tops":
                    InitializeDevice(MTG_StepOffsets.MTG_X_Step * 5 + MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Step * 4 + MTG_StepOffsets.MTG_Y_Offset);
                    DispenseDevice(MTG_StepOffsets.MTG_6mm_Z_Dispense);
                    LineGCode(MTG_StepOffsets.MTG_X_Step * 5 + MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Step * 4 + MTG_StepOffsets.MTG_Y_Offset,
                              MTG_StepOffsets.MTG_6mm_Z_Dispense, MTG_StepOffsets.MTG_FeedDispense);
                    RetractDevice(MTG_StepOffsets.MTG_6mm_Z_Retract, MTG_StepOffsets.MTG_FeedRetract);
                    break;
                case "MTG Bottoms":
                    InitializeDevice(MTG_StepOffsets.MTG_X_Step * 5 + MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Step * 4 + MTG_StepOffsets.MTG_Y_Offset);
                    DispenseDevice(MTG_StepOffsets.MTG_6mm_Z_Dispense);
                    //ArcGCode(wip)
                    RetractDevice(MTG_StepOffsets.MTG_6mm_Z_Retract, MTG_StepOffsets.MTG_FeedRetract);
                    break;
                default:
                    break;
            }
        }

        private void checkBox31_CheckedChanged(object sender, EventArgs e)
        {
            switch (comboBoxProductType.Text)
            {
                case "MTG Tops":
                    InitializeDevice(MTG_StepOffsets.MTG_X_Step * 5 + MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Step * 5 + MTG_StepOffsets.MTG_Y_Offset);
                    DispenseDevice(MTG_StepOffsets.MTG_6mm_Z_Dispense);
                    LineGCode(MTG_StepOffsets.MTG_X_Step * 5 + MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Step * 5 + MTG_StepOffsets.MTG_Y_Offset,
                              MTG_StepOffsets.MTG_6mm_Z_Dispense, MTG_StepOffsets.MTG_FeedDispense);
                    RetractDevice(MTG_StepOffsets.MTG_6mm_Z_Retract, MTG_StepOffsets.MTG_FeedRetract);
                    break;
                case "MTG Bottoms":
                    InitializeDevice(MTG_StepOffsets.MTG_X_Step * 5 + MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Step * 5 + MTG_StepOffsets.MTG_Y_Offset);
                    DispenseDevice(MTG_StepOffsets.MTG_6mm_Z_Dispense);
                    //ArcGCode(wip)
                    RetractDevice(MTG_StepOffsets.MTG_6mm_Z_Retract, MTG_StepOffsets.MTG_FeedRetract);
                    break;
                default:
                    break;
            }
        }

        private void checkBox32_CheckedChanged(object sender, EventArgs e)
        {
            switch (comboBoxProductType.Text)
            {
                case "MTG Tops":
                    InitializeDevice(MTG_StepOffsets.MTG_X_Step * 4 + MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Step * 5 + MTG_StepOffsets.MTG_Y_Offset);
                    DispenseDevice(MTG_StepOffsets.MTG_6mm_Z_Dispense);
                    LineGCode(MTG_StepOffsets.MTG_X_Step * 4 + MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Step * 5 + MTG_StepOffsets.MTG_Y_Offset,
                              MTG_StepOffsets.MTG_6mm_Z_Dispense, MTG_StepOffsets.MTG_FeedDispense);
                    RetractDevice(MTG_StepOffsets.MTG_6mm_Z_Retract, MTG_StepOffsets.MTG_FeedRetract);
                    break;
                case "MTG Bottoms":
                    InitializeDevice(MTG_StepOffsets.MTG_X_Step * 4 + MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Step * 5 + MTG_StepOffsets.MTG_Y_Offset);
                    DispenseDevice(MTG_StepOffsets.MTG_6mm_Z_Dispense);
                    //ArcGCode(wip)
                    RetractDevice(MTG_StepOffsets.MTG_6mm_Z_Retract, MTG_StepOffsets.MTG_FeedRetract);
                    break;
                default:
                    break;
            }
        }

        private void checkBox33_CheckedChanged(object sender, EventArgs e)
        {
            switch (comboBoxProductType.Text)
            {
                case "MTG Tops":
                    InitializeDevice(MTG_StepOffsets.MTG_X_Step * 3 + MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Step * 5 + MTG_StepOffsets.MTG_Y_Offset);
                    DispenseDevice(MTG_StepOffsets.MTG_6mm_Z_Dispense);
                    LineGCode(MTG_StepOffsets.MTG_X_Step * 3 + MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Step * 5 + MTG_StepOffsets.MTG_Y_Offset,
                              MTG_StepOffsets.MTG_6mm_Z_Dispense, MTG_StepOffsets.MTG_FeedDispense);
                    RetractDevice(MTG_StepOffsets.MTG_6mm_Z_Retract, MTG_StepOffsets.MTG_FeedRetract);
                    break;
                case "MTG Bottoms":
                    InitializeDevice(MTG_StepOffsets.MTG_X_Step * 3 + MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Step * 5 + MTG_StepOffsets.MTG_Y_Offset);
                    DispenseDevice(MTG_StepOffsets.MTG_6mm_Z_Dispense);
                    //ArcGCode(wip)
                    RetractDevice(MTG_StepOffsets.MTG_6mm_Z_Retract, MTG_StepOffsets.MTG_FeedRetract);
                    break;
                default:
                    break;
            }
        }

        private void checkBox34_CheckedChanged(object sender, EventArgs e)
        {
            switch (comboBoxProductType.Text)
            {
                case "MTG Tops":
                    InitializeDevice(MTG_StepOffsets.MTG_X_Step * 2 + MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Step * 5 + MTG_StepOffsets.MTG_Y_Offset);
                    DispenseDevice(MTG_StepOffsets.MTG_6mm_Z_Dispense);
                    LineGCode(MTG_StepOffsets.MTG_X_Step * 2 + MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Step * 5 + MTG_StepOffsets.MTG_Y_Offset,
                              MTG_StepOffsets.MTG_6mm_Z_Dispense, MTG_StepOffsets.MTG_FeedDispense);
                    RetractDevice(MTG_StepOffsets.MTG_6mm_Z_Retract, MTG_StepOffsets.MTG_FeedRetract);
                    break;
                case "MTG Bottoms":
                    InitializeDevice(MTG_StepOffsets.MTG_X_Step * 2 + MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Step * 5 + MTG_StepOffsets.MTG_Y_Offset);
                    DispenseDevice(MTG_StepOffsets.MTG_6mm_Z_Dispense);
                    //ArcGCode(wip)
                    RetractDevice(MTG_StepOffsets.MTG_6mm_Z_Retract, MTG_StepOffsets.MTG_FeedRetract);
                    break;
                default:
                    break;
            }
        }

        private void checkBox35_CheckedChanged(object sender, EventArgs e)
        {
            switch (comboBoxProductType.Text)
            {
                case "MTG Tops":
                    InitializeDevice(MTG_StepOffsets.MTG_X_Step + MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Step * 5 + MTG_StepOffsets.MTG_Y_Offset);
                    DispenseDevice(MTG_StepOffsets.MTG_6mm_Z_Dispense);
                    LineGCode(MTG_StepOffsets.MTG_X_Step + MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Step * 5 + MTG_StepOffsets.MTG_Y_Offset,
                              MTG_StepOffsets.MTG_6mm_Z_Dispense, MTG_StepOffsets.MTG_FeedDispense);
                    RetractDevice(MTG_StepOffsets.MTG_6mm_Z_Retract, MTG_StepOffsets.MTG_FeedRetract);
                    break;
                case "MTG Bottoms":
                    InitializeDevice(MTG_StepOffsets.MTG_X_Step + MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Step * 5 + MTG_StepOffsets.MTG_Y_Offset);
                    DispenseDevice(MTG_StepOffsets.MTG_6mm_Z_Dispense);
                    //ArcGCode(wip)
                    RetractDevice(MTG_StepOffsets.MTG_6mm_Z_Retract, MTG_StepOffsets.MTG_FeedRetract);
                    break;
                default:
                    break;
            }
        }
        private void checkBox36_CheckedChanged(object sender, EventArgs e)
        {
            switch (comboBoxProductType.Text)
            {
                case "MTG Tops":
                    InitializeDevice(MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Step * 5 + MTG_StepOffsets.MTG_Y_Offset);
                    DispenseDevice(MTG_StepOffsets.MTG_6mm_Z_Dispense);
                    LineGCode(MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Step * 5 + MTG_StepOffsets.MTG_Y_Offset,
                              MTG_StepOffsets.MTG_6mm_Z_Dispense, MTG_StepOffsets.MTG_FeedDispense);
                    RetractDevice(MTG_StepOffsets.MTG_6mm_Z_Retract, MTG_StepOffsets.MTG_FeedRetract);
                    break;
                case "MTG Bottoms":
                    InitializeDevice(MTG_StepOffsets.MTG_X_Offset, MTG_StepOffsets.MTG_Y_Step * 5 + MTG_StepOffsets.MTG_Y_Offset);
                    DispenseDevice(MTG_StepOffsets.MTG_6mm_Z_Dispense);
                    //ArcGCode(wip)
                    RetractDevice(MTG_StepOffsets.MTG_6mm_Z_Retract, MTG_StepOffsets.MTG_FeedRetract);
                    break;
                default:
                    break;
            }
        }

        private void buttonCheckAll_Click(object sender, EventArgs e)
        {
            foreach (var box in this.Controls.OfType<CheckBox>())
            {
                if (box.Checked == false)
                {
                    box.Checked = true;
                }
            }
        }

        private void buttonUncheckAll_Click(object sender, EventArgs e)
        {
            G_CodeStart(MTG_StepOffsets.MTG_6mm_Z_Retract, MTG_StepOffsets.MTG_FeedDefault);

            foreach (var box in this.Controls.OfType<CheckBox>())
            {
                if (box.Checked == true)
                {
                    box.Checked = false;
                }
            }
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            switch (comboBoxProductType.Text)
            {
                case "MTG Tops":
                    foreach (var box in this.Controls.OfType<CheckBox>())
                    {
                        if (box.Checked == true)
                        {
                            processCheckboxes(box.Text, sender, e);
                        }
                    }
                    break;
                case "MTG Bottoms":
                    foreach (var box in this.Controls.OfType<CheckBox>())
                    {
                        if (box.Checked == true)
                        {
                            processCheckboxes(box.Text, sender, e);
                        }
                    }
                    break;
                default:
                    MessageBox.Show("No product type selected.");
                    break;
            }

            if (comboBoxProductType.Text != String.Empty)
            {
                G_CodeEnd(0, 200, 90, 10000);
                File.WriteAllText(textBoxFilePath.Text, G_Code);
                Clipboard.SetText(textBoxFilePath.Text);
                G_CodeStart(MTG_StepOffsets.MTG_6mm_Z_Retract, MTG_StepOffsets.MTG_FeedDefault);
            }
        }


    }
}