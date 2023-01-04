using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace _8086sim
{
    public partial class Form1 : Form
    {
        public Random rand = new Random();
        public short AX, BX, CX, DX;
        public short ERR = -32768;
        public enum Instruction
        {
            None,
            ADD,
            SUB,
            MOV,
            MUL,
            CMP,
            DIV
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GenerateRegister();
            UpdateTextBoxes();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var msg = MessageBox.Show("Chcesz manualnie uzupelnic rejestry czy losowo? [TAK dla manualnie]", "Rejestry", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(msg == DialogResult.Yes) 
            {
                AX = Int16.Parse(Microsoft.VisualBasic.Interaction.InputBox("Podaj AX:", "AX", "0", 0, 0));
                BX = Int16.Parse(Microsoft.VisualBasic.Interaction.InputBox("Podaj BX:", "AX", "0", 0, 0));
                CX = Int16.Parse(Microsoft.VisualBasic.Interaction.InputBox("Podaj CX:", "AX", "0", 0, 0));
                DX = Int16.Parse(Microsoft.VisualBasic.Interaction.InputBox("Podaj DX:", "AX", "0", 0, 0));
            }
            else
            {
                GenerateRegister();
            }
            UpdateTextBoxes();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Instruction instruction;
            string instr = Microsoft.VisualBasic.Interaction.InputBox("Podaj operacje do wykonania (ADD, SUB, MOV, MUL, CMP, DIV)", "Operacja", "CMP", 0, 0);
            string reg1_txt = Microsoft.VisualBasic.Interaction.InputBox("Podaj rejestr pierwszy aby wykonac na nim operacje:", "Rejestr 1", "AX", 0, 0);
            string reg2_txt = Microsoft.VisualBasic.Interaction.InputBox("Podaj rejestr drugi aby wykonac na nim operacje:", "Rejestr 2", "BX", 0, 0);

            Enum.TryParse<Instruction>(instr, true, out instruction);

            int res = RunInstruction(instruction, ref GetReg(reg1_txt), ref GetReg(reg2_txt));
            if (instr == "CMP")
            {
                MessageBox.Show("Wynik porownania to: " + res.ToString());
            }
            UpdateTextBoxes();
        }

        private void GenerateRegister()
        {
            AX = (short)rand.Next(Int16.MinValue, Int16.MaxValue);
            BX = (short)rand.Next(Int16.MinValue, Int16.MaxValue);
            CX = (short)rand.Next(Int16.MinValue, Int16.MaxValue);
            DX = (short)rand.Next(Int16.MinValue, Int16.MaxValue);
        }
        private void UpdateTextBoxes()
        {
            AX_textBox.Text = AX.ToString();
            BX_textBox.Text = BX.ToString();
            CX_textBox.Text = CX.ToString();
            DX_textBox.Text = DX.ToString();
        }
        private int RunInstruction(Instruction instruction, ref short reg1, ref short reg2)
        {
            switch (instruction)
            {
                case Instruction.None:
                    return 0;
                case Instruction.ADD:
                    short sum = (short)(reg1 + reg2);
                    reg1 += reg2;
                    return sum;
                case Instruction.SUB:
                    short subtraction = (short)(reg1 - reg2);
                    reg1 -= reg2;
                    return subtraction;
                case Instruction.MOV:
                    reg2 = reg1;
                    return reg1;
                case Instruction.MUL:
                    short multiplication = (short)(reg1 * reg2);
                    reg1 *= reg2;
                    return multiplication;
                case Instruction.CMP:
                    if (reg1 == reg2)
                        return 1;
                    else
                        return 0;
                case Instruction.DIV:
                    if (reg2 != 0)
                    {
                        short division = (short)(reg1 / reg2);
                        reg1 /= reg2;
                        return division;
                    }
                    else
                    {
                        return ERR;
                    }
                default:
                    return ERR;

            }
        }
        private ref short GetReg(string reg_txt)
        {
            if(reg_txt == "AX")
            {
                return ref AX;
            }
            else if(reg_txt == "BX")
            {
                return ref BX;
            }
            else if (reg_txt == "CX")
            {
                return ref CX;
            }
            else if (reg_txt == "DX")
            {
                return ref DX;
            }

            return ref ERR;
        }
    }
}
