﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Espace de nom contenant tous les contrôles utilisateur.
/// </summary>
namespace Dyslexique.UI.UserControls
{
    /// <summary>
    /// Contrôle utilisateur affichant la page "Accueil".
    /// </summary>
    public partial class Accueil : CustomUserControl
    {
        /// <summary>
        /// Constructeur par défaut de la page "Accueil".
        /// </summary>
        public Accueil()
        {
            InitializeComponent();

            this.Title = "Accueil";
        }
    }
}
