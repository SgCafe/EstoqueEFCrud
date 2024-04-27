using System;
using System.Windows.Forms;

namespace EstoqueEFCrud.Util
{
    public static class MessageBoxUtil
    {
        public static void Erro(Form form, Exception ex)
            => MessageBox.Show(form, ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

        public static void Aviso(Form form, string mensagem)
            => MessageBox.Show(form, mensagem, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        public static void Sucesso(Form form, string mensagem = "Operação realizada com sucesso!")
            => MessageBox.Show(form, mensagem, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.None);
    }
}
