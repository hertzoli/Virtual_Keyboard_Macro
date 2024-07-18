using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp18
{
    public partial class Form1 : Form
    {


        KeyboardHook keyboardHook = new KeyboardHook();
        KeyEvent[] HistoricoEventoTeclas = new KeyEvent[3];

        string SequenciaAEnviar = "";
        int Intervalo = 350;
        ConsoleBox MeuConsole;
        public Form1()
        {
            InitializeComponent();


            Task D = Task.Run(() =>
            {
                try
                {
                    var update = new OnlineAutoUpdate.OnlineAutoUpdate();
                }
                catch
                {
                }
            });


            // register evens
            keyboardHook.KeyDown += new KeyboardHook.KeyboardHookCallback(keyboardHook_KeyDown);
            keyboardHook.KeyUp += new KeyboardHook.KeyboardHookCallback(keyboardHook_KeyUp);

            keyboardHook.Install();


            this.Text += "  v" + Application.ProductVersion;

            MeuConsole = new ConsoleBox(richTextBox, false);
        }



        //evento que captura o keyUP das teclas do teclado
        void keyboardHook_KeyUp(KeyboardHook.VKeys key)
        {

            HistoricoEventoTeclas[0] = HistoricoEventoTeclas[1];
            HistoricoEventoTeclas[1] = HistoricoEventoTeclas[2];

            HistoricoEventoTeclas[2].key = key;
            HistoricoEventoTeclas[2].TipoEvento = KeyPressState.Up;

            VerificaTeclas();
        }

        //evento que captura o keyDown das teclas do teclado
        void keyboardHook_KeyDown(KeyboardHook.VKeys key)
        {
            HistoricoEventoTeclas[0] = HistoricoEventoTeclas[1];
            HistoricoEventoTeclas[1] = HistoricoEventoTeclas[2];

            HistoricoEventoTeclas[2].key = key;
            HistoricoEventoTeclas[2].TipoEvento = KeyPressState.Down;

        }

        private void VerificaTeclas()
        {
            foreach (var item in HistoricoEventoTeclas)
            {
                if (item.TipoEvento == KeyPressState.Down)
                {
                    return;
                }
            }

            if (HistoricoEventoTeclas[0].key == KeyboardHook.VKeys.F12 && HistoricoEventoTeclas[1].key == KeyboardHook.VKeys.LMENU && HistoricoEventoTeclas[2].key == KeyboardHook.VKeys.LCONTROL)
            {
                executaColar();
                return;
            }

            if (HistoricoEventoTeclas[0].key == KeyboardHook.VKeys.F12 && HistoricoEventoTeclas[2].key == KeyboardHook.VKeys.LMENU && HistoricoEventoTeclas[1].key == KeyboardHook.VKeys.LCONTROL)
            {
                executaColar();
                return;
            }

            if (HistoricoEventoTeclas[1].key == KeyboardHook.VKeys.F12 && HistoricoEventoTeclas[0].key == KeyboardHook.VKeys.LMENU && HistoricoEventoTeclas[2].key == KeyboardHook.VKeys.LCONTROL)
            {
                executaColar();
                return;
            }

            if (HistoricoEventoTeclas[2].key == KeyboardHook.VKeys.F12 && HistoricoEventoTeclas[0].key == KeyboardHook.VKeys.LMENU && HistoricoEventoTeclas[1].key == KeyboardHook.VKeys.LCONTROL)
            {
                executaColar();
                return;
            }

            if (HistoricoEventoTeclas[1].key == KeyboardHook.VKeys.F12 && HistoricoEventoTeclas[2].key == KeyboardHook.VKeys.LMENU && HistoricoEventoTeclas[0].key == KeyboardHook.VKeys.LCONTROL)
            {
                executaColar();
                return;
            }

            if (HistoricoEventoTeclas[2].key == KeyboardHook.VKeys.F12 && HistoricoEventoTeclas[1].key == KeyboardHook.VKeys.LMENU && HistoricoEventoTeclas[0].key == KeyboardHook.VKeys.LCONTROL)
            {
                executaColar();
                return;
            }

        }


        private void executaColar()
        {

            // colar conteúdo do clipboard para o textbox
            String clipboardText = null;
            if (Clipboard.ContainsText() == true)
            {
                //clipboardText = Clipboard.GetText();
                clipboardText = Clipboard.GetText(TextDataFormat.Text);
                //clipboardText4 = Clipboard.GetText(TextDataFormat.UnicodeText);
                //Clipboard.SetText(replacementHtmlText, TextDataFormat.Html);
            }
            else
            {
                return;
            }
            richTextBox.Text = clipboardText;

            Intervalo = 0;

            SequenciaAEnviar = clipboardText;

            labelInfo.Text = "Enviando direto do clipboard";
            labelInfo.ForeColor = Color.Red;
            labelInfo.Visible = true;

            enviaSequenciDeTeclas();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            int.TryParse(textBoxIntervalo.Text, out Intervalo);

            labelInfo.Text = "Selecione a janela para enviar a sequencia de teclado";
            labelInfo.ForeColor = Color.Red;
            labelInfo.Visible = true;

            SequenciaAEnviar = richTextBox.Text;

        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            enviaSequenciDeTeclas();
        }

        private void enviaSequenciDeTeclas()
        {
            if (SequenciaAEnviar == null)
            {
                return;
            }

            if (SequenciaAEnviar.Length > 0)
            {
                Stopwatch stopwatch = new Stopwatch();

                stopwatch.Start();


                labelInfo.ForeColor = Color.DarkOrange;
                labelInfo.Visible = true;
                labelInfo.Refresh();

                while (stopwatch.ElapsedMilliseconds <= Intervalo)
                {
                    System.Threading.Thread.Sleep(1);
                    labelInfo.Text = "Aguarde : " + (((decimal)stopwatch.ElapsedMilliseconds / 1000)).ToString("0.0") + " Segundos";
                    labelInfo.Refresh();
                }

                //todo: aguardar liberar teclas de modificação alt, ctrl, e shift
                while (ModifierKeys.HasFlag(Keys.Control) == true)
                {
                    System.Threading.Thread.Sleep(1);
                    labelInfo.Text = "Solte a tecla Control para continuar";
                    labelInfo.Refresh();
                }
                while (ModifierKeys.HasFlag(Keys.Alt) == true)
                {
                    System.Threading.Thread.Sleep(1);
                    labelInfo.Text = "Solte a tecla Alt para continuar";
                    labelInfo.Refresh();
                }
                while (ModifierKeys.HasFlag(Keys.Shift) == true)
                {
                    System.Threading.Thread.Sleep(1);
                    labelInfo.Text = "Solte a tecla Shift para continuar";
                    labelInfo.Refresh();
                }

                labelInfo.Text = "Enviando...";
                labelInfo.ForeColor = Color.Blue;
                labelInfo.Refresh();
                if (checkBoxDelayEntreTeclas.Checked == true)
                {
                    NativeMethods.SendCaractereArray(SequenciaAEnviar, int.Parse(textBoxDelayEntreTeclas.Text.Trim()));
                }
                else
                {
                    NativeMethods.SendCaractereArray(SequenciaAEnviar, 0);
                }
                SequenciaAEnviar = "";


                labelInfo.Text = "Enviado...";
                labelInfo.ForeColor = Color.Green;
                labelInfo.Refresh();

            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            keyboardHook.Uninstall();
            keyboardHook.KeyUp -= new KeyboardHook.KeyboardHookCallback(keyboardHook_KeyUp);
            keyboardHook.KeyDown -= new KeyboardHook.KeyboardHookCallback(keyboardHook_KeyDown);
        }

        struct KeyEvent
        {
            public KeyboardHook.VKeys key;
            public KeyPressState TipoEvento;
        }

        enum KeyPressState
        {
            Down, Up
        }

        private void checkBoxHabilitaEnviarDoClipboard_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxHabilitaEnviarDoClipboard.Checked == true)
            {


                keyboardHook.KeyUp += new KeyboardHook.KeyboardHookCallback(keyboardHook_KeyUp);
                keyboardHook.KeyDown += new KeyboardHook.KeyboardHookCallback(keyboardHook_KeyDown);
                keyboardHook.Install();
            }
            else
            {
                keyboardHook.Uninstall();
                keyboardHook.KeyUp -= new KeyboardHook.KeyboardHookCallback(keyboardHook_KeyUp);
                keyboardHook.KeyDown -= new KeyboardHook.KeyboardHookCallback(keyboardHook_KeyDown);


            }

        }
    }
}
