using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Objects;

namespace WinFormsApp1.Service
{
    public class VetService
    {
            public async Task LoadVetsAsync(DataGridView gridView)
            {
                try
                {
                    DataTable vets = await Program.dbServices.DbReadVet.GetAllVetsAsync();
                    gridView.DataSource = vets;
                }
                catch (Exception)
                {
                    MessageBox.Show("Error: Failed to load veterinarians");
                    gridView.DataSource = null;
                }
            }
            public async Task HandleAddVetAsync(TextBox txtFirstName, TextBox txtLastName,
                                          TextBox txtUsername, TextBox txtPassword,
                                          TextBox txtThesis)
            {
                if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                    string.IsNullOrWhiteSpace(txtUsername.Text) ||
                    string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    MessageBox.Show("First name, username and password are required");
                    return;
                }

                string passwordHash = PasswordHelper.HashPassword(txtPassword.Text);

                VetClass newVet = new VetClass(
                     0,
                txtFirstName.Text,
                txtLastName.Text,
                txtUsername.Text,
                passwordHash,
                txtThesis.Text
            );

                await Program.dbServices.DbCreateVet.CreateVetAsync(newVet);
                MessageBox.Show("Veterinarian added successfully!");
            }

            public async Task<VetClass> AuthenticateAsync(string username, string password)
            {
                return await Program.dbServices.DbReadVet.AuthenticateVetAsync(username, password);
            }
        }
    }

