﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba.AbmSucursal
{
    public partial class modificar_sucursalElegida : Form
    {
        String nombre;
        String cp;
        String direccion;

        public modificar_sucursalElegida(String nombreViejo, String codigoPostalViejo, String direccionViejo)
        {
            InitializeComponent();

            nombre = nombreViejo;
            cp = codigoPostalViejo;
            direccion = direccionViejo;

            if (!System.Text.RegularExpressions.Regex.IsMatch(textCodigoPostal.Text, @"^\d+$"))
            {
                MessageBox.Show("Sólo se permiten numeros en el Codigo Postal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            if (!(textHabilitado.Text == "0" || textHabilitado.Text == "1"))
            {
                MessageBox.Show("Ingrese 1 o 0 para la habilitación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            String[] datosClienteElegido = new String[4];
            //datosClienteElegido = Database.getDatosCliente(nombreViejo, codigoPostalViejo, direccionViejo);
            textNombreN.Text = datosClienteElegido[0];
            textCodigoPostal.Text = datosClienteElegido[1];
            textDireccionN.Text = datosClienteElegido[2];
            textHabilitado.Text = datosClienteElegido[3];


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        public void button2_Click(object sender, EventArgs e)
        {

            String nombreNuevo = textNombreN.Text;
            String CodigoPostalNuevo = textCodigoPostal.Text;
            String direccionNueva = textDireccionN.Text;
            String habilitadoNuevo = textHabilitado.Text;
            if (nombreNuevo == "" | CodigoPostalNuevo == "" | direccionNueva == "" | habilitadoNuevo == "")
            {
                MessageBox.Show("Verifique que los campos obligatorios hayan sido completados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
                //Database.modificarCliente(nombre, codigoPostal, direccion, nombreNuevo, CodigoPostalNuevo, direccionNuevo, habilitadoNuevo);
                this.Close();
            }


        }


    }

