using Gtk;

namespace ExemploGtkNet8;

public class frmAtualizarPessoa : Window
{
    public frmAtualizarPessoa()
        : this(new Builder($"{nameof(frmAtualizarPessoa)}.glade"))
    {
    }

    private frmAtualizarPessoa(Builder builder) 
        : base(builder.GetRawOwnedObject($"{nameof(frmAtualizarPessoa)}"))
    {
        this.Title = "Atualizar pessoa";
        builder.Autoconnect(this);
    }
}