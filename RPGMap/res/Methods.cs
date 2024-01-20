using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace RPGMap.res
{
    class Methods
    {
        public static bool incrementando = false, decrementando = false;
        public static void IncrementarContador(Label label, ref int contador)
        {
                int tiempoEspera = 185;
                while (incrementando && contador < 100)
                {
                    Thread.Sleep(tiempoEspera);
                    if (!incrementando) break;
                    contador++;
                    tiempoEspera = Math.Max(70, tiempoEspera - 8);
                    ActualizarContador(label, contador);
                }
            
        }

        public static void IncrementarContador10(Label label, ref int contador)
        {
            int tiempoEspera = 185;
            while (incrementando && contador < 10)
            {
                Thread.Sleep(tiempoEspera);
                if (!incrementando) break;
                contador++;
                tiempoEspera = Math.Max(70, tiempoEspera - 8);
                ActualizarContador(label, contador);
            }

        }

        public static void DecrementarContador(Label label, ref int contador)
        {
                int tiempoEspera = 185;
                while (decrementando && contador > 0)
                {
                    Thread.Sleep(tiempoEspera);
                    if (!decrementando) break;
                    contador--;
                    tiempoEspera = Math.Max(70, tiempoEspera - 8);
                    ActualizarContador(label, contador);
                }
            
        }

        private static void ActualizarContador(Label label, int contador)
        {
                if (label.InvokeRequired)
                {
                    label.Invoke(new Action(() => ActualizarContador(label, contador)));
                }
                else
                {
                    if (label.Text.Contains("%"))
                    {
                        label.Text = contador + "%";
                    }
                    else
                    {
                        label.Text = contador.ToString();
                    }
                }
            
        }

        public static void OcultarButton(Button button)
        {
            if (button.InvokeRequired)
            {
                // Si no estamos en el hilo de la interfaz de usuario, invocamos la operación en ese hilo
                button.Invoke(new MethodInvoker(() => button.Visible = false));
            }
            else
            {
                // Estamos en el hilo de la interfaz de usuario, simplemente realizamos la operación
                button.Visible = false;
            }
        }

        public static void MostrarButton(Button button)
        {
            if (button.InvokeRequired)
            {
                // Si no estamos en el hilo de la interfaz de usuario, invocamos la operación en ese hilo
                button.Invoke(new MethodInvoker(() => button.Visible = true));
            }
            else
            {
                // Estamos en el hilo de la interfaz de usuario, simplemente realizamos la operación
                button.Visible = true;
            }
        }
    }
}
