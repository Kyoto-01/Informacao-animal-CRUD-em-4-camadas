namespace AnimalInfo
{
    partial class Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbx_animais = new System.Windows.Forms.ListBox();
            this.pic_animal = new System.Windows.Forms.PictureBox();
            this.lbl_animais = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_filo = new System.Windows.Forms.Label();
            this.lbl_classe = new System.Windows.Forms.Label();
            this.lbl_ordem = new System.Windows.Forms.Label();
            this.lbl_familia = new System.Windows.Forms.Label();
            this.lbl_habitat = new System.Windows.Forms.Label();
            this.lbl_estado_conserv = new System.Windows.Forms.Label();
            this.lbl_descricao = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_filo = new System.Windows.Forms.TextBox();
            this.txt_classe = new System.Windows.Forms.TextBox();
            this.txt_ordem = new System.Windows.Forms.TextBox();
            this.txt_familia = new System.Windows.Forms.TextBox();
            this.txt_habitat = new System.Windows.Forms.TextBox();
            this.txt_estado_conserv = new System.Windows.Forms.TextBox();
            this.txt_descricao = new System.Windows.Forms.TextBox();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.btn_remover = new System.Windows.Forms.Button();
            this.btn_foto = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_animal)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            resources.ApplyResources(this.lbl_titulo, "lbl_titulo");
            this.lbl_titulo.Name = "lbl_titulo";
            // 
            // lbx_animais
            // 
            resources.ApplyResources(this.lbx_animais, "lbx_animais");
            this.lbx_animais.BackColor = System.Drawing.Color.White;
            this.lbx_animais.FormattingEnabled = true;
            this.lbx_animais.Name = "lbx_animais";
            this.lbx_animais.SelectedIndexChanged += new System.EventHandler(this.lbx_animais_SelectedIndexChanged);
            // 
            // pic_animal
            // 
            resources.ApplyResources(this.pic_animal, "pic_animal");
            this.pic_animal.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pic_animal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_animal.Name = "pic_animal";
            this.pic_animal.TabStop = false;
            // 
            // lbl_animais
            // 
            resources.ApplyResources(this.lbl_animais, "lbl_animais");
            this.lbl_animais.Name = "lbl_animais";
            // 
            // lbl_nome
            // 
            resources.ApplyResources(this.lbl_nome, "lbl_nome");
            this.lbl_nome.Name = "lbl_nome";
            // 
            // lbl_filo
            // 
            resources.ApplyResources(this.lbl_filo, "lbl_filo");
            this.lbl_filo.Name = "lbl_filo";
            // 
            // lbl_classe
            // 
            resources.ApplyResources(this.lbl_classe, "lbl_classe");
            this.lbl_classe.Name = "lbl_classe";
            // 
            // lbl_ordem
            // 
            resources.ApplyResources(this.lbl_ordem, "lbl_ordem");
            this.lbl_ordem.Name = "lbl_ordem";
            // 
            // lbl_familia
            // 
            resources.ApplyResources(this.lbl_familia, "lbl_familia");
            this.lbl_familia.Name = "lbl_familia";
            // 
            // lbl_habitat
            // 
            resources.ApplyResources(this.lbl_habitat, "lbl_habitat");
            this.lbl_habitat.Name = "lbl_habitat";
            // 
            // lbl_estado_conserv
            // 
            resources.ApplyResources(this.lbl_estado_conserv, "lbl_estado_conserv");
            this.lbl_estado_conserv.Name = "lbl_estado_conserv";
            // 
            // lbl_descricao
            // 
            resources.ApplyResources(this.lbl_descricao, "lbl_descricao");
            this.lbl_descricao.Name = "lbl_descricao";
            // 
            // txt_nome
            // 
            resources.ApplyResources(this.txt_nome, "txt_nome");
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.ReadOnly = true;
            // 
            // txt_filo
            // 
            resources.ApplyResources(this.txt_filo, "txt_filo");
            this.txt_filo.Name = "txt_filo";
            this.txt_filo.ReadOnly = true;
            // 
            // txt_classe
            // 
            resources.ApplyResources(this.txt_classe, "txt_classe");
            this.txt_classe.Name = "txt_classe";
            this.txt_classe.ReadOnly = true;
            // 
            // txt_ordem
            // 
            resources.ApplyResources(this.txt_ordem, "txt_ordem");
            this.txt_ordem.Name = "txt_ordem";
            this.txt_ordem.ReadOnly = true;
            // 
            // txt_familia
            // 
            resources.ApplyResources(this.txt_familia, "txt_familia");
            this.txt_familia.Name = "txt_familia";
            this.txt_familia.ReadOnly = true;
            // 
            // txt_habitat
            // 
            resources.ApplyResources(this.txt_habitat, "txt_habitat");
            this.txt_habitat.Name = "txt_habitat";
            this.txt_habitat.ReadOnly = true;
            // 
            // txt_estado_conserv
            // 
            resources.ApplyResources(this.txt_estado_conserv, "txt_estado_conserv");
            this.txt_estado_conserv.Name = "txt_estado_conserv";
            this.txt_estado_conserv.ReadOnly = true;
            // 
            // txt_descricao
            // 
            resources.ApplyResources(this.txt_descricao, "txt_descricao");
            this.txt_descricao.AllowDrop = true;
            this.txt_descricao.Name = "txt_descricao";
            this.txt_descricao.ReadOnly = true;
            // 
            // btn_editar
            // 
            resources.ApplyResources(this.btn_editar, "btn_editar");
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_confirmar
            // 
            resources.ApplyResources(this.btn_confirmar, "btn_confirmar");
            this.btn_confirmar.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_confirmar.ForeColor = System.Drawing.Color.White;
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.UseVisualStyleBackColor = false;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
            // 
            // btn_adicionar
            // 
            resources.ApplyResources(this.btn_adicionar, "btn_adicionar");
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.UseVisualStyleBackColor = true;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // btn_remover
            // 
            resources.ApplyResources(this.btn_remover, "btn_remover");
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.UseVisualStyleBackColor = true;
            this.btn_remover.Click += new System.EventHandler(this.btn_remover_Click);
            // 
            // btn_foto
            // 
            resources.ApplyResources(this.btn_foto, "btn_foto");
            this.btn_foto.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_foto.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btn_foto.Name = "btn_foto";
            this.btn_foto.UseVisualStyleBackColor = false;
            this.btn_foto.Click += new System.EventHandler(this.btn_foto_Click);
            // 
            // btn_cancelar
            // 
            resources.ApplyResources(this.btn_cancelar, "btn_cancelar");
            this.btn_cancelar.BackColor = System.Drawing.Color.Red;
            this.btn_cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // Principal
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.Controls.Add(this.btn_foto);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_confirmar);
            this.Controls.Add(this.btn_remover);
            this.Controls.Add(this.btn_adicionar);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.txt_descricao);
            this.Controls.Add(this.txt_estado_conserv);
            this.Controls.Add(this.txt_habitat);
            this.Controls.Add(this.txt_familia);
            this.Controls.Add(this.txt_ordem);
            this.Controls.Add(this.txt_classe);
            this.Controls.Add(this.txt_filo);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.lbl_descricao);
            this.Controls.Add(this.lbl_estado_conserv);
            this.Controls.Add(this.lbl_habitat);
            this.Controls.Add(this.lbl_familia);
            this.Controls.Add(this.lbl_ordem);
            this.Controls.Add(this.lbl_classe);
            this.Controls.Add(this.lbl_filo);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.pic_animal);
            this.Controls.Add(this.lbx_animais);
            this.Controls.Add(this.lbl_animais);
            this.Controls.Add(this.lbl_titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_animal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.ListBox lbx_animais;
        private System.Windows.Forms.PictureBox pic_animal;
        private System.Windows.Forms.Label lbl_animais;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_filo;
        private System.Windows.Forms.Label lbl_classe;
        private System.Windows.Forms.Label lbl_ordem;
        private System.Windows.Forms.Label lbl_familia;
        private System.Windows.Forms.Label lbl_habitat;
        private System.Windows.Forms.Label lbl_estado_conserv;
        private System.Windows.Forms.Label lbl_descricao;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_filo;
        private System.Windows.Forms.TextBox txt_classe;
        private System.Windows.Forms.TextBox txt_ordem;
        private System.Windows.Forms.TextBox txt_familia;
        private System.Windows.Forms.TextBox txt_habitat;
        private System.Windows.Forms.TextBox txt_estado_conserv;
        private System.Windows.Forms.TextBox txt_descricao;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.Button btn_remover;
        private System.Windows.Forms.Button btn_foto;
        private System.Windows.Forms.Button btn_cancelar;
    }
}