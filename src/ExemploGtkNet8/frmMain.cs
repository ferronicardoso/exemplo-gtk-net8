using System;
using Gtk;
using UI = Gtk.Builder.ObjectAttribute;

namespace ExemploGtkNet8
{
    public class frmMain : Window
    {
        [UI] private Button _btnConsultarPessoa = null;
        [UI] private Button _btnIncluirPessoa = null;
        [UI] private Button _btnAtualizarPessoa = null;
        [UI] private Button _btnExcluirPessoa = null;

        [UI] private MessageDialog dlgExcluir = null;

        public frmMain() 
            : this(new Builder("frmMain.glade"))
        {
        }

        private frmMain(Builder builder) 
            : base(builder.GetRawOwnedObject("frmMain"))
        {
            this.Title = "Cadastro de pessoas - NET 8, Entity Framework e Postgre";
            builder.Autoconnect(this);

            DeleteEvent += Window_DeleteEvent;

            _btnConsultarPessoa.Clicked += btnConsultarPessoa_Clicked;
            _btnIncluirPessoa.Clicked += btnIncluirPessoa_Clicked;
            _btnAtualizarPessoa.Clicked += btnAtualizarPessoa_Clicked;
            _btnExcluirPessoa.Clicked += btnExcluirPessoa_Clicked;
        }

        private void Window_DeleteEvent(object sender, DeleteEventArgs a)
        {
            Application.Quit();
        }

        private void btnConsultarPessoa_Clicked(object sender, EventArgs a)
        {

        }

        private void btnIncluirPessoa_Clicked(object sender, EventArgs a)
        {
            var frmIncluirPessoa = new frmIncluirPessoa();
            frmIncluirPessoa.Parent = this;
            frmIncluirPessoa.Show();
        }

        private void btnAtualizarPessoa_Clicked(object sender, EventArgs a)
        {
            var frmAtualizarPessoa = new frmAtualizarPessoa();
            frmAtualizarPessoa.Show();
        }

        private void btnExcluirPessoa_Clicked(object sender, EventArgs a)
        {
            var result = (ResponseType)dlgExcluir.Run();
            if (result == ResponseType.Yes)
            {
                // TODO: Excluir o registro
            }
        }
    }
}