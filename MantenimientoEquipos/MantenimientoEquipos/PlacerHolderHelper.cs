using MantenimientoEquipos.ModifierComponents;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MantenimientoEquipos
{
    public static class PlaceholderHelper
    {
        /// <summary>
        /// Establece un placeholder para un EstandarTextBox.
        /// </summary>
        /// <param name="textBox">Nombre del componente</param>
        /// <param name="placeholder">Texto deseado para poner de  placeholder</param>
        public static void SetPlaceholder(EstandarTextBox textBox, string placeholder)
        {
            textBox.Tag = placeholder; // Guarda el placeholder individual en la propiedad Tag
            textBox.ForeColor = Color.Gray;
            textBox.Text = placeholder;

            textBox.Enter -= RemovePlaceholder;
            textBox.Leave -= ApplyPlaceholder;

            textBox.Enter += RemovePlaceholder;
            textBox.Leave += ApplyPlaceholder;
        }

        private static void RemovePlaceholder(object sender, EventArgs e)
        {
            var textBox = sender as EstandarTextBox;
            if ( textBox != null && textBox.Text == ( string ) textBox.Tag )
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
            }
        }

        private static void ApplyPlaceholder(object sender, EventArgs e)
        {
            var textBox = sender as EstandarTextBox;
            if ( textBox != null && string.IsNullOrWhiteSpace(textBox.Text) )
            {
                textBox.Text = ( string ) textBox.Tag;
                textBox.ForeColor = Color.Gray;
            }
        }

        /// <summary>
        /// Establece un placeholder para un EstandarTextBox que es una contraseña.
        /// </summary>
        /// <param name="textBox">Nombre del componente</param>
        /// <param name="placeholder">Texto deseado para poner de  placeholder</param>
        /// <param name="isPassword">Corroborar que es conrtaseña poniendo "True"</param>
        public static void SetPlaceholder(EstandarTextBox textBox, string placeholder, bool isPassword)
        {
            textBox.Tag = placeholder; // Guarda el placeholder individual en la propiedad Tag
            textBox.ForeColor = Color.Gray;
            textBox.Text = placeholder;

            textBox.Enter -= RemovePlaceholderPass;
            textBox.Leave -= ApplyPlaceholderPass;

            textBox.Enter += RemovePlaceholderPass;
            textBox.Leave += ApplyPlaceholderPass;

        }

        private static void RemovePlaceholderPass(object sender, EventArgs e)
        {
            var textBox = sender as EstandarTextBox;
            if ( textBox != null && textBox.Text == ( string ) textBox.Tag )
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
                textBox.UseSystemPasswordChar = true; // Cambia a modo contraseña
            }
        }

        private static void ApplyPlaceholderPass(object sender, EventArgs e)
        {
            var textBox = sender as EstandarTextBox;
            if ( textBox != null && string.IsNullOrWhiteSpace(textBox.Text) )
            {
                textBox.Text = ( string ) textBox.Tag;
                textBox.ForeColor = Color.Gray;
                textBox.UseSystemPasswordChar = false; // Cambia a modo texto normal
            }
        }

        /// <summary>
        /// Establece un placeholder para un EstandarTextBox.
        /// </summary>
        /// <param name="textBox">Nombre del componente</param>
        /// <param name="placeholder">Texto deseado para poner de  placeholder</param>
        public static void SetRichPlaceholder(EstandarRichTextBox textBox, string placeholder)
        {
            textBox.Tag = placeholder; // Guarda el placeholder individual en la propiedad Tag
            textBox.ForeColor = Color.Gray;
            textBox.Text = placeholder;

            textBox.Enter -= RemoveRichPlaceholder;
            textBox.Leave -= ApplyRichPlaceholder;

            textBox.Enter += RemoveRichPlaceholder;
            textBox.Leave += ApplyRichPlaceholder;
        }

        private static void RemoveRichPlaceholder(object sender, EventArgs e)
        {
            var textBox = sender as EstandarRichTextBox;
            if ( textBox != null && textBox.Text == ( string ) textBox.Tag )
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
            }
        }

        private static void ApplyRichPlaceholder(object sender, EventArgs e)
        {
            var textBox = sender as EstandarRichTextBox;
            if ( textBox != null && string.IsNullOrWhiteSpace(textBox.Text) )
            {
                textBox.Text = ( string ) textBox.Tag;
                textBox.ForeColor = Color.Gray;
            }
        }
    }
}
