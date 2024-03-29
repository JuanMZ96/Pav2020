﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;
using Pav2.Logica;


namespace Pav2.Presentacion
{
    public partial class Login : Form
    {
        Principal principal1 { get; set; }
        bool Cerrar = true;
        public  Login(Principal data)
        {
            InitializeComponent();
            this.principal1 = data;
            this.ActiveControl = label1;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txt_nameid.Text == "Usuario" || txt_pwd.Text == "Contraseña")
            {
                MessageBox.Show("Complete los campos.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txt_nameid.Text != String.Empty && txt_pwd.Text != String.Empty)
            {
                ReturnValue<CustomClass.UsuarioCustom> valido = Logica.Usuarios.ValidarCredenciales(txt_nameid.Text, txt_pwd.Text);
                if (valido.isSuccess)
                {
                    Cerrar = false;
                    principal1.guardarUsuario(valido.Data);
                    this.Close();
                }
                else 
                { 
                    MessageBox.Show(valido.ErrorMessage,"Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_nameid.Clear(); 
                    txt_pwd.Clear();
                }
            }
            else
            {
                MessageBox.Show("Complete los campos.","Alerta", MessageBoxButtons.OK ,MessageBoxIcon.Warning);
            }

        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ( Cerrar == true)
            {
                Environment.Exit(0);
            }
        }

        private void txt_pwd_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnIngresar_Click(sender,e);
            }
            if(e.KeyChar == Convert.ToChar(Keys.Escape))
            {
                Login_FormClosing(sender, null);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void txt_nameid_Enter(object sender, EventArgs e)
        {
            if (txt_nameid.Text == "Usuario") {
                txt_nameid.Text = "";
                txt_nameid.ForeColor = Color.Black;
            }
        }

        private void txt_nameid_Leave(object sender, EventArgs e)
        {
            if (txt_nameid.Text == "") {
                txt_nameid.Text = "Usuario";
                txt_nameid.ForeColor = Color.DimGray;
            }
        }

        private void txt_pwd_Enter(object sender, EventArgs e)
        {
            if (txt_pwd.Text == "Contraseña") {
                txt_pwd.Text = "";
                txt_pwd.ForeColor = Color.Black;
                txt_pwd.UseSystemPasswordChar = true;
            }
        }

        private void txt_pwd_Leave(object sender, EventArgs e)
        {
            if (txt_pwd.Text == "") {
                txt_pwd.Text = "Contraseña";
                txt_pwd.ForeColor = Color.DimGray;
                txt_pwd.UseSystemPasswordChar = false;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Reestablecer su contraseña no es posible en este momento.", "Lo sentimos...");
        }
    }
    
}
