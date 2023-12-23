using Gtk;

namespace ExemploGtkNet8;

public class frmIncluirPessoa : Window
{
    public frmIncluirPessoa()
        : this(new Builder($"{nameof(frmIncluirPessoa)}.glade"))
    {
    }

    private frmIncluirPessoa(Builder builder) 
        : base(builder.GetRawOwnedObject($"{nameof(frmIncluirPessoa)}"))
    {
        this.Title = "Incluir pessoa";
        builder.Autoconnect(this);
    }
}