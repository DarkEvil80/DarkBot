usando o  sistema . Windows . Formulários ;

namespace  Corvus
{
     classe  parcial FrmMain
    {
        /// < resumo >
        /// Erforderliche Designervariable.
        /// </ resumo >
        System.ComponentModel privado . Componentes IContainer  = nulo ;  

        /// < resumo >
        /// Verwendete Ressourcen bereinigen.
        /// </ resumo >
        /// < param  name = " disposing " > Verdadeiro, sem dúvida Ressourcen gelöscht werden sollen; andernfalls False. </ param >
         anulação  protegida anular  Dispose ( eliminação de bool  )
        {
            if ( descarte  && ( componentes  ! =  nulo ))
            {
                componentes . Dispose ();
            }
            base . Descarte ( descarte );
        }

        # region  Vom Windows Form Designer Designer Código

        /// < resumo >
        /// Método Forçado para o Projeto de Instalação.
        /// O Inhalt der Methode darf nicht with the Code-Editor geändert werden.
        /// </ resumo >
        private  void  InitializeComponent ()
        {
            isso . componentes  =  novo  sistema . ComponentModel . Container ();
            Sistema . ComponentModel . Recursos ComponentResourceManager  = new System . ComponentModel . ComponentResourceManager ( typeof ( FrmMain ));   
            isso . tcMain  =  novo  sistema . Windows . Formulários . TabControl ();
            isso . tabPageLogin  =  novo  sistema . Windows . Formulários . TabPage ();
            isso . gBoxGeneralSettings  =  novo  sistema . Windows . Formulários . GroupBox ();
            isso . chkBoxActLog  =  novo  sistema . Windows . Formulários . CheckBox ();
            isso . chkBoxHideName  =  novo  sistema . Windows . Formulários . CheckBox ();
            isso . lblAccount  =  novo  sistema . Windows . Formulários . Label ();
            isso . chkBoxStartAgainTaskDestroy  =  novo  sistema . Windows . Formulários . CheckBox ();
            isso . chkBoxActivateTheNotification  =  novo  sistema . Windows . Formulários . CheckBox ();
            isso . label1  =  novo  sistema . Windows . Formulários . Label ();
            isso . cmdLogin  =  novo  sistema . Windows . Formulários . Button ();
            isso . gBoxUsernamePasswordLogin  =  novo  sistema . Windows . Formulários . GroupBox ();
            isso . chkBoxSaveUsernamePassword  =  novo  sistema . Windows . Formulários . CheckBox ();
            isso . lblPortal  =  novo  sistema . Windows . Formulários . Label ();
            isso . comboBoxLoginPortal  =  novo  sistema . Windows . Formulários . ComboBox ();
            isso . rbUsernamePasswordLogin  =  novo  sistema . Windows . Formulários . RadioButton ();
            isso . chkBoxReconnect  =  novo  sistema . Windows . Formulários . CheckBox ();
            isso . txtPassword  =  novo  sistema . Windows . Formulários . TextBox ();
            isso . lblPassword  =  novo  sistema . Windows . Formulários . Label ();
            isso . txtUsername  =  novo  sistema . Windows . Formulários . TextBox ();
            isso . lblUsername  =  novo  sistema . Windows . Formulários . Label ();
            isso . gBoxSessionIDLogin  =  novo  sistema . Windows . Formulários . GroupBox ();
            isso . rbSessionIdLogin  =  novo  sistema . Windows . Formulários . RadioButton ();
            isso . txtSessionId  =  novo  sistema . Windows . Formulários . TextBox ();
            isso . lblSessionId  =  novo  sistema . Windows . Formulários . Label ();
            isso . txtServer  =  novo  sistema . Windows . Formulários . TextBox ();
            isso . lblServer  =  novo  sistema . Windows . Formulários . Label ();
            isso . tabPageGalaxyGates  =  novo  sistema . Windows . Formulários . TabPage ();
            isso . nudMaxSpinCost  =  novo  sistema . Windows . Formulários . NumericUpDown ();
            isso . lblMaxSpinCost  =  novo  sistema . Windows . Formulários . Label ();
            isso . lblSettingsGates  =  novo  sistema . Windows . Formulários . Label ();
            isso . lblEnergyBoost  =  novo  sistema . Windows . Formulários . Label ();
            isso . comboBoxEnergyBoost  =  novo  sistema . Windows . Formulários . ComboBox ();
            isso . chkBoxSmartMultiplier  =  novo  sistema . Windows . Formulários . CheckBox ();
            isso . lblMultiplier  =  novo  sistema . Windows . Formulários . Label ();
            isso . comboBoxMultiplier  =  novo  sistema . Windows . Formulários . ComboBox ();
            isso . lblWaitGate  =  novo  sistema . Windows . Formulários . Label ();
            isso . nudGateWait  =  novo  sistema . Windows . Formulários . NumericUpDown ();
            isso . comboBoxOptionABG  =  novo  sistema . Windows . Formulários . ComboBox ();
            isso . lblGates  =  novo  sistema . Windows . Formulários . Label ();
            isso . lblStatistics  =  novo  sistema . Windows . Formulários . Label ();
            isso . lblAccountInfo  =  novo  sistema . Windows . Formulários . Label ();
            isso . chkSpinOnlyEE  =  novo  sistema . Windows . Formulários . CheckBox ();
            isso . nudMinimumUridium  =  novo  sistema . Windows . Formulários . NumericUpDown ();
            isso . lblMinimumUridium  =  novo  sistema . Windows . Formulários . Label ();
            isso . chkBoxPlaceGate  =  novo  sistema . Windows . Formulários . CheckBox ();
            isso . chkBoxSpinGate  =  novo  sistema . Windows . Formulários . CheckBox ();
            isso . lblReceivedParts  =  novo  sistema . Windows . Formulários . Label ();
            isso . nudGateDelay  =  novo  sistema . Windows . Formulários . NumericUpDown ();
            isso . lblGateDelay  =  novo  sistema . Windows . Formulários . Label ();
            isso . lblSpinCost  =  novo  sistema . Windows . Formulários . Label ();
            isso . lblReceivedNanoHull  =  novo  sistema . Windows . Formulários . Label ();
            isso . lblReceivedXenomit  =  novo  sistema . Windows . Formulários . Label ();
            isso . lblReceivedRepairCredits  =  novo  sistema . Windows . Formulários . Label ();
            isso . lblReceivedLogDisks  =  novo  sistema . Windows . Formulários . Label ();
            isso . lblReceivedACM  =  novo  sistema . Windows . Formulários . Label ();
            isso . lblReceivedPLT2021  =  novo  sistema . Windows . Formulários . Label ();
            isso . lblReceivedSAB  =  novo  sistema . Windows . Formulários . Label ();
            isso . lblReceivedX4  =  novo  sistema . Windows . Formulários . Label ();
            isso . lblReceivedX3  =  novo  sistema . Windows . Formulários . Label ();
            isso . lblReceivedX2  =  novo  sistema . Windows . Formulários . Label ();
            isso . lblTotalSpins  =  novo  sistema . Windows . Formulários . Label ();
            isso . lblExtraEnergy  =  novo  sistema . Windows . Formulários . Label ();
            isso . lblUridium  =  novo  sistema . Windows . Formulários . Label ();
            isso . dgvGates  =  novo  sistema . Windows . Formulários . DataGridView ();
            isso . clmnGateName  =  novo  sistema . Windows . Formulários . DataGridViewTextBoxColumn ();
            isso . clmnGateParts  =  novo  sistema . Windows . Formulários . DataGridViewTextBoxColumn ();
            isso . clmnGateReady  =  novo  sistema . Windows . Formulários . DataGridViewCheckBoxColumn ();
            isso . clmnGateOnMap  =  novo  sistema . Windows . Formulários . DataGridViewCheckBoxColumn ();
            isso . clmnGatesBuilt  =  novo  sistema . Windows . Formulários . DataGridViewTextBoxColumn ();
            isso . cmdResetGateStats  =  novo  sistema . Windows . Formulários . Button ();
            isso . rbBuildKuiper  =  novo  sistema . Windows . Formulários . RadioButton ();
            isso . rbBuildHades  =  novo  sistema . Windows . Formulários . RadioButton ();
            isso . rbBuildKappa  =  novo  sistema . Windows . Formulários . RadioButton ();
            isso . rbBuildLambda  =  novo  sistema . Windows . Formulários . RadioButton ();
            isso . rbBuildZeta  =  novo  sistema . Windows . Formulários . RadioButton ();
            isso . rbBuildEpsilon  =  novo  sistema . Windows . Formulários . RadioButton ();
            isso . rbBuildDelta  =  novo  sistema . Windows . Formulários . RadioButton ();
            isso . rbBuildABG  =  novo  sistema . Windows . Formulários . RadioButton ();
            isso . tabPageTechFactory  =  novo  sistema . Windows . Formulários . TabPage ();
            isso . nudCheckTechFactoryEvery  =  novo  sistema . Windows . Formulários . NumericUpDown ();
            isso . lblCheckTechFactoryEvery  =  novo  sistema . Windows . Formulários . Label ();
            isso . chkBoxBuildTechs  =  novo  sistema . Windows . Formulários . CheckBox ();
            isso . dgvTechFactory  =  novo  sistema . Windows . Formulários . DataGridView ();
            isso . clmnTechName  =  novo  sistema . Windows . Formulários . DataGridViewTextBoxColumn ();
            isso . clmnTechAmount  =  novo  sistema . Windows . Formulários . DataGridViewTextBoxColumn ();
            isso . clmnTechBuilding  =  novo  sistema . Windows . Formulários . DataGridViewCheckBoxColumn ();
            isso . clmnTechTimeLeft  =  novo  sistema . Windows . Formulários . DataGridViewTextBoxColumn ();
            isso . clmnTechBuild  =  novo  sistema . Windows . Formulários . DataGridViewCheckBoxColumn ();
            isso . tabPageSkylab  =  novo  sistema . Windows . Formulários . TabPage ();
            isso . nudCheckSkylabEvery  =  novo  sistema . Windows . Formulários . NumericUpDown ();
            isso . lblCheckSkylabEvery  =  novo  sistema . Windows . Formulários . Label ();
            isso . chkBoxUpgradeSkylab  =  novo  sistema . Windows . Formulários . CheckBox ();
            isso . dgvSkylab  =  novo  sistema . Windows . Formulários . DataGridView ();
            isso . clmnModuleName  =  novo  sistema . Windows . Formulários . DataGridViewTextBoxColumn ();
            isso . clmnModuleLevel  =  novo  sistema . Windows . Formulários . DataGridViewTextBoxColumn ();
            isso . clmnModuleUpgrading  =  novo  sistema . Windows . Formulários . DataGridViewCheckBoxColumn ();
            isso . clmnModuleTimeLeft  =  novo  sistema . Windows . Formulários . DataGridViewTextBoxColumn ();
            isso . clmnModuleUpgrade  =  novo  sistema . Windows . Formulários . DataGridViewCheckBoxColumn ();
            isso . tabPageLog  =  novo  sistema . Windows . Formulários . TabPage ();
            isso . rtbLog  =  novo  sistema . Windows . Formulários . RichTextBox ();
            isso . cmdStart  =  novo  sistema . Windows . Formulários . Button ();
            isso . cmdStop  =  novo  sistema . Windows . Formulários . Button ();
            isso . cmdOpenBackPage  =  novo  sistema . Windows . Formulários . Button ();
            isso . lblLastStatus  =  novo  sistema . Windows . Formulários . Label ();
            isso . cmdSaveSettings  =  novo  sistema . Windows . Formulários . Button ();
            isso . notifyIcon1  =  novo  sistema . Windows . Formulários . NotifyIcon ( este . Componentes );
            isso . tcMain . SuspendLayout ();
            isso . tabPageLogin . SuspendLayout ();
            isso . gBoxGeneralSettings . SuspendLayout ();
            isso . gBoxUsernamePasswordLogin . SuspendLayout ();
            isso . gBoxSessionIDLogin . SuspendLayout ();
            isso . tabPageGalaxyGates . SuspendLayout ();
            (( System . ComponentModel . ISupportInitialize ) ( este . NudMaxSpinCost )). BeginInit ();
            (( System . ComponentModel . ISupportInitialize ) ( este . NudGateWait )). BeginInit ();
            (( System . ComponentModel . ISupportInitialize ) ( este . NudMinimumUridium )). BeginInit ();
            (( System . ComponentModel . ISupportInitialize ) ( este . NudGateDelay )). BeginInit ();
            (( System . ComponentModel . ISupportInitialize ) ( este . DgvGates )). BeginInit ();
            isso . tabPageTechFactory . SuspendLayout ();
            (( System . ComponentModel . ISupportInitialize ) ( este . NudCheckTechFactoryEvery )). BeginInit ();
            (( System . ComponentModel . ISupportInitialize ) ( este . DgvTechFactory )). BeginInit ();
            isso . tabPageSkylab . SuspendLayout ();
            (( System . ComponentModel . ISupportInitialize ) ( este . NudCheckSkylabEvery )). BeginInit ();
            (( System . ComponentModel . ISupportInitialize ) ( este . DgvSkylab )). BeginInit ();
            isso . tabPageLog . SuspendLayout ();
            isso . SuspendLayout ();
            // 
            // tcMain
            // 
            isso . tcMain . Controles . Adicionar ( este . TabPageLogin );
            isso . tcMain . Controles . Adicionar ( este . TabPageGalaxyGates );
            isso . tcMain . Controles . Adicionar ( este . TabPageTechFactory );
            isso . tcMain . Controles . Adicionar ( este . TabPageSkylab );
            isso . tcMain . Controles . Adicionar ( este . TabPageLog );
            isso . tcMain . Localização  =  novo  sistema . Desenho . Ponto ( 13 , 39 );
            isso . tcMain . Nome  =  " tcMain " ;
            isso . tcMain . SelectedIndex  =  0 ;
            isso . tcMain . Tamanho  =  novo  sistema . Desenho . Tamanho ( 775 , 484 );
            isso . tcMain . TabIndex  =  0 ;
            // 
            // tabPageLogin
            // 
            isso . tabPageLogin . Controles . Adicionar ( este . GBoxGeneralSettings );
            isso . tabPageLogin . Controles . Adicione ( este . CmdLogin );
            isso . tabPageLogin . Controles . Adicionar ( este . GBoxUsernamePasswordLogin );
            isso . tabPageLogin . Controles . Adicionar ( este . GBoxSessionIDLogin );
            isso . tabPageLogin . Localização  =  novo  sistema . Desenho . Ponto ( 4 , 22 );
            isso . tabPageLogin . Nome  =  " tabPageLogin " ;
            isso . tabPageLogin . Tamanho  =  novo  sistema . Desenho . Tamanho ( 767 , 458 );
            isso . tabPageLogin . TabIndex  =  0 ;
            isso . tabPageLogin . Texto  =  " Login " ;
            isso . tabPageLogin . UseVisualStyleBackColor  =  true ;
            // 
            // gBoxGeneralSettings
            // 
            isso . gBoxGeneralSettings . Controles . Adicionar ( este . ChkBoxActLog );
            isso . gBoxGeneralSettings . Controles . Adicionar ( este . ChkBoxHideName );
            isso . gBoxGeneralSettings . Controles . Adicionar ( este . LblAccount );
            isso . gBoxGeneralSettings . Controles . Adicionar ( este . ChkBoxStartAgainTaskDestroy );
            isso . gBoxGeneralSettings . Controles . Add ( este . ChkBoxActivateTheNotification );
            isso . gBoxGeneralSettings . Controles . Adicionar ( este . Rótulo1 );
            isso . gBoxGeneralSettings . Localização  =  novo  sistema . Desenho . Ponto ( 407 , 21 );
            isso . gBoxGeneralSettings . Nome  =  " gBoxGeneralSettings " ;
            isso . gBoxGeneralSettings . Tamanho  =  novo  sistema . Desenho . Tamanho ( 318 , 249 );
            isso . gBoxGeneralSettings . TabIndex  =  8 ;
            isso . gBoxGeneralSettings . TabStop  =  false ;
            isso . gBoxGeneralSettings . Texto  =  " Configurações gerais " ;
            // 
            // chkBoxActLog
            // 
            isso . chkBoxActLog . AutoSize  =  true ;
            isso . chkBoxActLog . Verificado  =  verdadeiro ;
            isso . chkBoxActLog . CheckState  =  Sistema . Windows . Formulários . CheckState . Verificado ;
            isso . chkBoxActLog . Localização  =  novo  sistema . Desenho . Ponto ( 32 , 93 );
            isso . chkBoxActLog . Nome  =  " chkBoxActLog " ;
            isso . chkBoxActLog . Tamanho  =  novo  sistema . Desenho . Tamanho ( 76 , 17 );
            isso . chkBoxActLog . TabIndex  =  5 ;
            isso . chkBoxActLog . Texto  =  " Ativar log " ;
            isso . chkBoxActLog . UseVisualStyleBackColor  =  true ;
            isso . chkBoxActLog . CheckedChanged  + =  novo  sistema . EventHandler ( este . ChkBoxActLog_CheckedChanged );
            // 
            // chkBoxHideName
            // 
            isso . chkBoxHideName . AutoSize  =  true ;
            isso . chkBoxHideName . Localização  =  novo  sistema . Desenho . Ponto ( 32 , 138 );
            isso . chkBoxHideName . Nome  =  " chkBoxHideName " ;
            isso . chkBoxHideName . Tamanho  =  novo  sistema . Desenho . Tamanho ( 77 , 17 );
            isso . chkBoxHideName . TabIndex  =  4 ;
            isso . chkBoxHideName . Texto  =  " Ocultar nome " ;
            isso . chkBoxHideName . UseVisualStyleBackColor  =  true ;
            isso . chkBoxHideName . CheckedChanged  + =  novo  sistema . EventHandler ( este . ChkBoxHideName_CheckedChanged );
            // 
            // lblAccount
            // 
            isso . lblAccount . AutoSize  =  true ;
            isso . lblAccount . Localização  =  novo  sistema . Desenho . Ponto ( 6 , 122 );
            isso . lblAccount . Nome  =  " lblAccount " ;
            isso . lblAccount . Tamanho  =  novo  sistema . Desenho . Tamanho ( 50 , 13 );
            isso . lblAccount . TabIndex  =  3 ;
            isso . lblAccount . Texto  =  " Conta: " ;
            // 
            // chkBoxStartAgainTaskDestroy
            // 
            isso . chkBoxStartAgainTaskDestroy . AutoSize  =  true ;
            isso . chkBoxStartAgainTaskDestroy . Localização  =  novo  sistema . Desenho . Ponto ( 32 , 70 );
            isso . chkBoxStartAgainTaskDestroy . Nome  =  " chkBoxStartAgainTaskDestroy " ;
            isso . chkBoxStartAgainTaskDestroy . Tamanho  =  novo  sistema . Desenho . Tamanho ( 155 , 17 );
            isso . chkBoxStartAgainTaskDestroy . TabIndex  =  2 ;
            isso . chkBoxStartAgainTaskDestroy . Text  =  " Iniciar novamente se a tarefa for destruída " ;
            isso . chkBoxStartAgainTaskDestroy . UseVisualStyleBackColor  =  true ;
            // 
            // chkBoxActivateTheNotification
            // 
            isso . chkBoxActivateTheNotification . AutoSize  =  true ;
            isso . chkBoxActivateTheNotification . Localização  =  novo  sistema . Desenho . Ponto ( 32 , 47 );
            isso . chkBoxActivateTheNotification . Nome  =  " chkBoxActivateTheNotification " ;
            isso . chkBoxActivateTheNotification . Tamanho  =  novo  sistema . Desenho . Tamanho ( 113 , 17 );
            isso . chkBoxActivateTheNotification . TabIndex  =  1 ;
            isso . chkBoxActivateTheNotification . Texto  =  " Ativar notificação " ;
            isso . chkBoxActivateTheNotification . UseVisualStyleBackColor  =  true ;
            // 
            // label1
            // 
            isso . label1 . AutoSize  =  true ;
            isso . label1 . Localização  =  novo  sistema . Desenho . Ponto ( 6 , 25 );
            isso . label1 . Nome  =  " label1 " ;
            isso . label1 . Tamanho  =  novo  sistema . Desenho . Tamanho ( 49 , 13 );
            isso . label1 . TabIndex  =  0 ;
            isso . label1 . Texto  =  " Programa: " ;
            // 
            // cmdLogin
            // 
            isso . cmdLogin . Localização  =  novo  sistema . Desenho . Ponto ( 18 , 247 );
            isso . cmdLogin . Nome  =  " cmdLogin " ;
            isso . cmdLogin . Tamanho  =  novo  sistema . Desenho . Tamanho ( 330 , 23 );
            isso . cmdLogin . TabIndex  =  7 ;
            isso . cmdLogin . Texto  =  " Login " ;
            isso . cmdLogin . UseVisualStyleBackColor  =  true ;
            isso . cmdLogin . Clique em  + =  novo  sistema . EventHandler ( este . CmdLogin_Click );
            // 
            // gBoxUsernamePasswordLogin
            // 
            isso . gBoxUsernamePasswordLogin . Controles . Adicionar ( este . ChkBoxSaveUsernamePassword );
            isso . gBoxUsernamePasswordLogin . Controles . Adicionar ( este . LblPortal );
            isso . gBoxUsernamePasswordLogin . Controles . Adicionar ( este . ComboBoxLoginPortal );
            isso . gBoxUsernamePasswordLogin . Controles . Adicionar ( este . RbUsernamePasswordLogin );
            isso . gBoxUsernamePasswordLogin . Controles . Adicionar ( este . ChkBoxReconnect );
            isso . gBoxUsernamePasswordLogin . Controles . Adicionar ( this . TxtPassword );
            isso . gBoxUsernamePasswordLogin . Controles . Adicione ( this . LblPassword );
            isso . gBoxUsernamePasswordLogin . Controles . Adicionar ( este . TxtUsername );
            isso . gBoxUsernamePasswordLogin . Controles . Adicionar ( este . LblUsername );
            isso . gBoxUsernamePasswordLogin . Localização  =  novo  sistema . Desenho . Ponto ( 18 , 21 );
            isso . gBoxUsernamePasswordLogin . Nome  =  " gBoxUsernamePasswordLogin " ;
            isso . gBoxUsernamePasswordLogin . Tamanho  =  novo  sistema . Desenho . Tamanho ( 330 , 131 );
            isso . gBoxUsernamePasswordLogin . TabIndex  =  0 ;
            isso . gBoxUsernamePasswordLogin . TabStop  =  false ;
            isso . gBoxUsernamePasswordLogin . Texto  =  "                                                       " ;
            // 
            // chkBoxSaveUsernamePassword
            // 
            isso . chkBoxSaveUsernamePassword . AutoSize  =  true ;
            isso . chkBoxSaveUsernamePassword . Verificado  =  verdadeiro ;
            isso . chkBoxSaveUsernamePassword . CheckState  =  Sistema . Windows . Formulários . CheckState . Verificado ;
            isso . chkBoxSaveUsernamePassword . Localização  =  novo  sistema . Desenho . Ponto ( 193 , 101 );
            isso . chkBoxSaveUsernamePassword . Nome  =  " chkBoxSaveUsernamePassword " ;
            isso . chkBoxSaveUsernamePassword . Tamanho  =  novo  sistema . Desenho . Tamanho ( 75 , 17 );
            isso . chkBoxSaveUsernamePassword . TabIndex  =  11 ;
            isso . chkBoxSaveUsernamePassword . Texto  =  " Salvar dados " ;
            isso . chkBoxSaveUsernamePassword . UseVisualStyleBackColor  =  true ;
            // 
            // lblPortal
            // 
            isso . lblPortal . AutoSize  =  true ;
            isso . lblPortal . Localização  =  novo  sistema . Desenho . Ponto ( 6 , 77 );
            isso . lblPortal . Nome  =  " lblPortal " ;
            isso . lblPortal . Tamanho  =  novo  sistema . Desenho . Tamanho ( 37 , 13 );
            isso . lblPortal . TabIndex  =  10 ;
            isso . lblPortal . Texto  =  " Portal: " ;
            // 
            // comboBoxLoginPortal
            // 
            isso . comboBoxLoginPortal . DropDownStyle  =  Sistema . Windows . Formulários . ComboBoxStyle . DropDownList ;
            isso . comboBoxLoginPortal . FormattingEnabled  =  true ;
            isso . comboBoxLoginPortal . Itens . AddRange ( novo  objeto [] {
            " https://darkorbit.com/ " ,
            " https://www.dark-orbit.it/ " ,
            " https://lp.darkorbit.com/ " });
            isso . comboBoxLoginPortal . Localização  =  novo  sistema . Desenho . Ponto ( 70 , 74 );
            isso . comboBoxLoginPortal . Nome  =  " comboBoxLoginPortal " ;
            isso . comboBoxLoginPortal . Tamanho  =  novo  sistema . Desenho . Tamanho ( 254 , 21 );
            isso . comboBoxLoginPortal . TabIndex  =  9 ;
            // 
            // rbUsernamePasswordLogin
            // 
            isso . rbUsernamePasswordLogin . AutoSize  =  true ;
            isso . rbUsernamePasswordLogin . Localização  =  novo  sistema . Desenho . Ponto ( 15 , 0 );
            isso . rbUsernamePasswordLogin . Nome  =  " rbUsernamePasswordLogin " ;
            isso . rbUsernamePasswordLogin . Tamanho  =  novo  sistema . Desenho . Tamanho ( 153 , 17 );
            isso . rbUsernamePasswordLogin . TabIndex  =  8 ;
            isso . rbUsernamePasswordLogin . Texto  =  " Nome de usuário / Senha de login " ;
            isso . rbUsernamePasswordLogin . UseVisualStyleBackColor  =  true ;
            isso . rbUsernamePasswordLogin . CheckedChanged  + =  novo  sistema . EventHandler ( this . RbUsernamePasswordLogin_CheckedChanged );
            // 
            // chkBoxReconnect
            // 
            isso . chkBoxReconnect . AutoSize  =  true ;
            isso . chkBoxReconnect . Verificado  =  verdadeiro ;
            isso . chkBoxReconnect . CheckState  =  Sistema . Windows . Formulários . CheckState . Verificado ;
            isso . chkBoxReconnect . Localização  =  novo  sistema . Desenho . Ponto ( 70 , 101 );
            isso . chkBoxReconnect . Nome  =  " chkBoxReconnect " ;
            isso . chkBoxReconnect . Tamanho  =  novo  sistema . Desenho . Tamanho ( 117 , 17 );
            isso . chkBoxReconnect . TabIndex  =  5 ;
            isso . chkBoxReconnect . Texto  =  " Reconectar ao chute " ;
            isso . chkBoxReconnect . UseVisualStyleBackColor  =  true ;
            // 
            // txtPassword
            // 
            isso . txtPassword . Localização  =  novo  sistema . Desenho . Ponto ( 70 , 48 );
            isso . txtPassword . Nome  =  " txtPassword " ;
            isso . txtPassword . PasswordChar  =  '*' ;
            isso . txtPassword . Tamanho  =  novo  sistema . Desenho . Tamanho ( 254 , 20 );
            isso . txtPassword . TabIndex  =  3 ;
            // 
            // lblPassword
            // 
            isso . lblPassword . AutoSize  =  true ;
            isso . lblPassword . Localização  =  novo  sistema . Desenho . Ponto ( 6 , 51 );
            isso . lblPassword . Nome  =  " lblPassword " ;
            isso . lblPassword . Tamanho  =  novo  sistema . Desenho . Tamanho ( 56 , 13 );
            isso . lblPassword . TabIndex  =  2 ;
            isso . lblPassword . Texto  =  " Senha: " ;
            // 
            // txtUsername
            // 
            isso . txtUsername . Localização  =  novo  sistema . Desenho . Ponto ( 70 , 22 );
            isso . txtUsername . Nome  =  " txtUsername " ;
            isso . txtUsername . Tamanho  =  novo  sistema . Desenho . Tamanho ( 254 , 20 );
            isso . txtUsername . TabIndex  =  1 ;
            // 
            // lblUsername
            // 
            isso . lblUsername . AutoSize  =  true ;
            isso . lblUsername . Localização  =  novo  sistema . Desenho . Ponto ( 6 , 25 );
            isso . lblUsername . Nome  =  " lblUsername " ;
            isso . lblUsername . Tamanho  =  novo  sistema . Desenho . Tamanho ( 58 , 13 );
            isso . lblUsername . TabIndex  =  0 ;
            isso . lblUsername . Texto  =  " Nome de usuário: " ;
            // 
            // gBoxSessionIDLogin
            // 
            isso . gBoxSessionIDLogin . Controles . Adicionar ( este . RbSessionIdLogin );
            isso . gBoxSessionIDLogin . Controles . Adicionar ( este . TxtSessionId );
            isso . gBoxSessionIDLogin . Controles . Adicionar ( este . LblSessionId );
            isso . gBoxSessionIDLogin . Controles . Adicionar ( este . TxtServer );
            isso . gBoxSessionIDLogin . Controles . Adicionar ( este . LblServer );
            isso . gBoxSessionIDLogin . Localização  =  novo  sistema . Desenho . Ponto ( 18 , 158 );
            isso . gBoxSessionIDLogin . Nome  =  " gBoxSessionIDLogin " ;
            isso . gBoxSessionIDLogin . Tamanho  =  novo  sistema . Desenho . Tamanho ( 330 , 83 );
            isso . gBoxSessionIDLogin . TabIndex  =  6 ;
            isso . gBoxSessionIDLogin . TabStop  =  false ;
            isso . gBoxSessionIDLogin . Texto  =  "                                     " ;
            // 
            // rbSessionIdLogin
            // 
            isso . rbSessionIdLogin . AutoSize  =  true ;
            isso . rbSessionIdLogin . Verificado  =  verdadeiro ;
            isso . rbSessionIdLogin . Localização  =  novo  sistema . Desenho . Ponto ( 15 , 0 );
            isso . rbSessionIdLogin . Nome  =  " rbSessionIdLogin " ;
            isso . rbSessionIdLogin . Tamanho  =  novo  sistema . Desenho . Tamanho ( 100 , 17 );
            isso . rbSessionIdLogin . TabIndex  =  9 ;
            isso . rbSessionIdLogin . TabStop  =  verdadeiro ;
            isso . rbSessionIdLogin . Texto  =  " Login do SessionId " ;
            isso . rbSessionIdLogin . UseVisualStyleBackColor  =  true ;
            isso . rbSessionIdLogin . CheckedChanged  + =  novo  sistema . EventHandler ( este . RbSessionIdLogin_CheckedChanged );
            // 
            // txtSessionId
            // 
            isso . txtSessionId . Localização  =  novo  sistema . Desenho . Ponto ( 70 , 49 );
            isso . txtSessionId . Nome  =  " txtSessionId " ;
            isso . txtSessionId . Tamanho  =  novo  sistema . Desenho . Tamanho ( 254 , 20 );
            isso . txtSessionId . TabIndex  =  3 ;
            // 
            // lblSessionId
            // 
            isso . lblSessionId . AutoSize  =  true ;
            isso . lblSessionId . Localização  =  novo  sistema . Desenho . Ponto ( 6 , 52 );
            isso . lblSessionId . Nome  =  " lblSessionId " ;
            isso . lblSessionId . Tamanho  =  novo  sistema . Desenho . Tamanho ( 56 , 13 );
            isso . lblSessionId . TabIndex  =  2 ;
            isso . lblSessionId . Texto  =  " SessionId: " ;
            // 
            // txtServer
            // 
            isso . txtServer . Localização  =  novo  sistema . Desenho . Ponto ( 70 , 23 );
            isso . txtServer . Nome  =  " txtServer " ;
            isso . txtServer . Tamanho  =  novo  sistema . Desenho . Tamanho ( 254 , 20 );
            isso . txtServer . TabIndex  =  1 ;
            // 
            // lblServer
            // 
            isso . lblServer . AutoSize  =  true ;
            isso . lblServer . Localização  =  novo  sistema . Desenho . Ponto ( 6 , 26 );
            isso . lblServer . Nome  =  " lblServer " ;
            isso . lblServer . Tamanho  =  novo  sistema . Desenho . Tamanho ( 41 , 13 );
            isso . lblServer . TabIndex  =  0 ;
            isso . lblServer . Texto  =  " Servidor: " ;
            // 
            // tabPageGalaxyGates
            // 
            isso . tabPageGalaxyGates . Controles . Adicionar ( este . NudMaxSpinCost );
            isso . tabPageGalaxyGates . Controles . Adicionar ( este . LblMaxSpinCost );
            isso . tabPageGalaxyGates . Controles . Adicionar ( este . LblSettingsGates );
            isso . tabPageGalaxyGates . Controles . Adicionar ( este . LblEnergyBoost );
            isso . tabPageGalaxyGates . Controles . Adicionar ( este . ComboBoxEnergyBoost );
            isso . tabPageGalaxyGates . Controles . Adicionar ( este . ChkBoxSmartMultiplier );
            isso . tabPageGalaxyGates . Controles . Adicionar ( este . LblMultiplier );
            isso . tabPageGalaxyGates . Controles . Adicionar ( este . ComboBoxMultiplier );
            isso . tabPageGalaxyGates . Controles . Adicionar ( este . LblWaitGate );
            isso . tabPageGalaxyGates . Controles . Adicionar ( este . NudGateWait );
            isso . tabPageGalaxyGates . Controles . Adicionar ( este . ComboBoxOptionABG );
            isso . tabPageGalaxyGates . Controles . Adicione ( this . LblGates );
            isso . tabPageGalaxyGates . Controles . Adicione ( this . LblStatistics );
            isso . tabPageGalaxyGates . Controles . Adicionar ( este . LblAccountInfo );
            isso . tabPageGalaxyGates . Controles . Adicionar ( este . ChkSpinOnlyEE );
            isso . tabPageGalaxyGates . Controles . Adicionar ( este . NudMinimumUridium );
            isso . tabPageGalaxyGates . Controles . Adicione ( this . LblMinimumUridium );
            isso . tabPageGalaxyGates . Controles . Adicionar ( este . ChkBoxPlaceGate );
            isso . tabPageGalaxyGates . Controles . Adicionar ( este . ChkBoxSpinGate );
            isso . tabPageGalaxyGates . Controles . Adicionar ( este . LblReceivedParts );
            isso . tabPageGalaxyGates . Controles . Adicionar ( este . NudGateDelay );
            isso . tabPageGalaxyGates . Controles . Adicionar ( este . LblGateDelay );
            isso . tabPageGalaxyGates . Controles . Adicionar ( este . LblSpinCost );
            isso . tabPageGalaxyGates . Controles . Adicionar ( este . LblReceivedNanoHull );
            isso . tabPageGalaxyGates . Controles . Adicionar ( este . LblReceivedXenomit );
            isso . tabPageGalaxyGates . Controles . Add ( este . LblReceivedRepairCredits );
            isso . tabPageGalaxyGates . Controles . Adicionar ( este . LblReceivedLogDisks );
            isso . tabPageGalaxyGates . Controles . Adicionar ( este . LblReceivedACM );
            isso . tabPageGalaxyGates . Controles . Adicionar ( este . LblReceivedPLT2021 );
            isso . tabPageGalaxyGates . Controles . Adicionar ( este . LblReceivedSAB );
            isso . tabPageGalaxyGates . Controles . Adicionar ( este . LblReceivedX4 );
            isso . tabPageGalaxyGates . Controles . Adicionar ( este . LblReceivedX3 );
            isso . tabPageGalaxyGates . Controles . Adicionar ( este . LblReceivedX2 );
            isso . tabPageGalaxyGates . Controles . Adicionar ( este . LblTotalSpins );
            isso . tabPageGalaxyGates . Controles . Adicionar ( este . LblExtraEnergy );
            isso . tabPageGalaxyGates . Controles . Adicionar ( este . LblUridium );
            isso . tabPageGalaxyGates . Controles . Adicionar ( este . DgvGates );
            isso . tabPageGalaxyGates . Controles . Adicionar ( este . CmdResetGateStats );
            isso . tabPageGalaxyGates . Controles . Adicionar ( este . RbBuildKuiper );
            isso . tabPageGalaxyGates . Controles . Adicionar ( este . RbBuildHades );
            isso . tabPageGalaxyGates . Controles . Adicionar ( este . RbBuildKappa );
            isso . tabPageGalaxyGates . Controles . Adicionar ( este . RbBuildLambda );
            isso . tabPageGalaxyGates . Controles . Adicionar ( este . RbBuildZeta );
            isso . tabPageGalaxyGates . Controles . Adicionar ( este . RbBuildEpsilon );
            isso . tabPageGalaxyGates . Controles . Adicionar ( este . RbBuildDelta );
            isso . tabPageGalaxyGates . Controles . Adicionar ( este . RbBuildABG );
            isso . tabPageGalaxyGates . Localização  =  novo  sistema . Desenho . Ponto ( 4 , 22 );
            isso . tabPageGalaxyGates . Nome  =  " tabPageGalaxyGates " ;
            isso . tabPageGalaxyGates . Tamanho  =  novo  sistema . Desenho . Tamanho ( 767 , 458 );
            isso . tabPageGalaxyGates . TabIndex  =  1 ;
            isso . tabPageGalaxyGates . Texto  =  " Portões da Galáxia " ;
            isso . tabPageGalaxyGates . UseVisualStyleBackColor  =  true ;
            // 
            // nudMaxSpinCost
            // 
            isso . nudMaxSpinCost . Localização  =  novo  sistema . Desenho . Ponto ( 98 , 234 );
            isso . nudMaxSpinCost . Nome  =  " nudMaxSpinCost " ;
            isso . nudMaxSpinCost . Tamanho  =  novo  sistema . Desenho . Tamanho ( 44 , 20 );
            isso . nudMaxSpinCost . TabIndex  =  52 ;
            isso . nudMaxSpinCost . Valor  =  novo  decimal ( new  int [] {
            55 ,
            0 ,
            0 ,
            0 });
            // 
            // lblMaxSpinCost
            // 
            isso . lblMaxSpinCost . AutoSize  =  true ;
            isso . lblMaxSpinCost . Localização  =  novo  sistema . Desenho . Ponto ( 17 , 236 );
            isso . lblMaxSpinCost . Nome  =  " lblMaxSpinCost " ;
            isso . lblMaxSpinCost . Tamanho  =  novo  sistema . Desenho . Tamanho ( 75 , 13 );
            isso . lblMaxSpinCost . TabIndex  =  51 ;
            isso . lblMaxSpinCost . Texto  =  " Custo máximo de rotação: " ;
            // 
            // lblSettingsGates
            // 
            isso . lblSettingsGates . AutoSize  =  true ;
            isso . lblSettingsGates . Fonte  =  novo  sistema . Desenho . Fonte ( " Microsoft Sans Serif " , 10.25F , Sistema . Desenho . FontStyle . Sublinhado , Sistema . Desenho . GraphicsUnit . Ponto , (( byte ) ( 0 )));
            isso . lblSettingsGates . Localização  =  novo  sistema . Desenho . Ponto ( 17 , 7 );
            isso . lblSettingsGates . Nome  =  " lblSettingsGates " ;
            isso . lblSettingsGates . Tamanho  =  novo  sistema . Desenho . Tamanho ( 63 , 17 );
            isso . lblSettingsGates . TabIndex  =  50 ;
            isso . lblSettingsGates . Texto  =  " Configurações: " ;
            // 
            // lblEnergyBoost
            // 
            isso . lblEnergyBoost . AutoSize  =  true ;
            isso . lblEnergyBoost . Localização  =  novo  sistema . Desenho . Ponto ( 17 , 93 );
            isso . lblEnergyBoost . Nome  =  " lblEnergyBoost " ;
            isso . lblEnergyBoost . Tamanho  =  novo  sistema . Desenho . Tamanho ( 73 , 13 );
            isso . lblEnergyBoost . TabIndex  =  49 ;
            isso . lblEnergyBoost . Texto  =  " Reforço de energia: " ;
            // 
            // comboBoxEnergyBoost
            // 
            isso . comboBoxEnergyBoost . AllowDrop  =  true ;
            isso . comboBoxEnergyBoost . DropDownStyle  =  Sistema . Windows . Formulários . ComboBoxStyle . DropDownList ;
            isso . comboBoxEnergyBoost . DropDownWidth  =  66 ;
            isso . comboBoxEnergyBoost . FormattingEnabled  =  true ;
            isso . comboBoxEnergyBoost . IntegralHeight  =  false ;
            isso . comboBoxEnergyBoost . Itens . AddRange ( novo  objeto [] {
            " 1 " ,
            " 5 " ,
            " 10 " ,
            " 100 " });
            isso . comboBoxEnergyBoost . Localização  =  novo  sistema . Desenho . Ponto ( 96 , 90 );
            isso . comboBoxEnergyBoost . Nome  =  " comboBoxEnergyBoost " ;
            isso . comboBoxEnergyBoost . Tamanho  =  novo  sistema . Desenho . Tamanho ( 46 , 21 );
            isso . comboBoxEnergyBoost . TabIndex  =  48 ;
            // 
            // chkBoxSmartMultiplier
            // 
            isso . chkBoxSmartMultiplier . AutoSize  =  true ;
            isso . chkBoxSmartMultiplier . Verificado  =  verdadeiro ;
            isso . chkBoxSmartMultiplier . CheckState  =  Sistema . Windows . Formulários . CheckState . Verificado ;
            isso . chkBoxSmartMultiplier . Localização  =  novo  sistema . Desenho . Ponto ( 20 , 164 );
            isso . chkBoxSmartMultiplier . Nome  =  " chkBoxSmartMultiplier " ;
            isso . chkBoxSmartMultiplier . Tamanho  =  novo  sistema . Desenho . Tamanho ( 96 , 17 );
            isso . chkBoxSmartMultiplier . TabIndex  =  47 ;
            isso . chkBoxSmartMultiplier . Texto  =  " Multiplicador inteligente " ;
            isso . chkBoxSmartMultiplier . UseVisualStyleBackColor  =  true ;
            isso . chkBoxSmartMultiplier . CheckedChanged  + =  novo  sistema . EventHandler ( este . ChkBoxMultiplierInt_CheckedChanged );
            // 
            // lblMultiplier
            // 
            isso . lblMultiplier . AutoSize  =  true ;
            isso . lblMultiplier . Localização  =  novo  sistema . Desenho . Ponto ( 17 , 187 );
            isso . lblMultiplier . Nome  =  " lblMultiplier " ;
            isso . lblMultiplier . Tamanho  =  novo  sistema . Desenho . Tamanho ( 51 , 13 );
            isso . lblMultiplier . TabIndex  =  46 ;
            isso . lblMultiplier . Texto  =  " Multiplicador: " ;
            // 
            // comboBoxMultiplier
            // 
            isso . comboBoxMultiplier . AllowDrop  =  true ;
            isso . comboBoxMultiplier . DropDownStyle  =  Sistema . Windows . Formulários . ComboBoxStyle . DropDownList ;
            isso . comboBoxMultiplier . DropDownWidth  =  66 ;
            isso . comboBoxMultiplier . FormattingEnabled  =  true ;
            isso . comboBoxMultiplier . IntegralHeight  =  false ;
            isso . comboBoxMultiplier . Itens . AddRange ( novo  objeto [] {
            " x2 " ,
            " x3 " ,
            " x4 " ,
            " x5 " ,
            " x6 " });
            isso . comboBoxMultiplier . Localização  =  novo  sistema . Desenho . Ponto ( 73 , 183 );
            isso . comboBoxMultiplier . Nome  =  " comboBoxMultiplier " ;
            isso . comboBoxMultiplier . Tamanho  =  novo  sistema . Desenho . Tamanho ( 69 , 21 );
            isso . comboBoxMultiplier . TabIndex  =  45 ;
            // 
            // lblWaitGate
            // 
            isso . lblWaitGate . AutoSize  =  true ;
            isso . lblWaitGate . Localização  =  novo  sistema . Desenho . Ponto ( 70 , 117 );
            isso . lblWaitGate . Nome  =  " lblWaitGate " ;
            isso . lblWaitGate . Tamanho  =  novo  sistema . Desenho . Tamanho ( 69 , 13 );
            isso . lblWaitGate . TabIndex  =  44 ;
            isso . lblWaitGate . Texto  =  " Aguarde (minuto) " ;
            // 
            // nudGateWait
            // 
            isso . nudGateWait . InterceptArrowKeys  =  false ;
            isso . nudGateWait . Localização  =  novo  sistema . Desenho . Ponto ( 20 , 114 );
            isso . nudGateWait . Máximo  =  novo  decimal ( new  int [] {
            60 ,
            0 ,
            0 ,
            0 });
            isso . nudGateWait . Mínimo  =  novo  decimal ( new  int [] {
            1 ,
            0 ,
            0 ,
            0 });
            isso . nudGateWait . Nome  =  " nudGateWait " ;
            isso . nudGateWait . Tamanho  =  novo  sistema . Desenho . Tamanho ( 50 , 20 );
            isso . nudGateWait . TabIndex  =  43 ;
            isso . nudGateWait . Valor  =  novo  decimal ( new  int [] {
            1 ,
            0 ,
            0 ,
            0 });
            // 
            // comboBoxOptionABG
            // 
            isso . comboBoxOptionABG . AllowDrop  =  true ;
            isso . comboBoxOptionABG . DropDownStyle  =  Sistema . Windows . Formulários . ComboBoxStyle . DropDownList ;
            isso . comboBoxOptionABG . DropDownWidth  =  253 ;
            isso . comboBoxOptionABG . FormattingEnabled  =  true ;
            isso . comboBoxOptionABG . IntegralHeight  =  false ;
            isso . comboBoxOptionABG . Itens . AddRange ( novo  objeto [] {
            " 1. Pare quando qualquer um dos 3 portais for 2/2. " ,
            " 2. Pare quando todos os portais forem 2/2. " ,
            " 3. Pare quando o portal alfa for 2/2. " ,
            " 4. Pare quando o portal beta for 2/2. " ,
            " 5. Pare quando o portal gama for 2/2. " });
            isso . comboBoxOptionABG . Localização  =  novo  sistema . Desenho . Ponto ( 73 , 275 );
            isso . comboBoxOptionABG . Nome  =  " comboBoxOptionABG " ;
            isso . comboBoxOptionABG . Tamanho  =  novo  sistema . Desenho . Tamanho ( 69 , 21 );
            isso . comboBoxOptionABG . TabIndex  =  42 ;
            // 
            // lblGates
            // 
            isso . lblGates . AutoSize  =  true ;
            isso . lblGates . Fonte  =  novo  sistema . Desenho . Fonte ( " Microsoft Sans Serif " , 10.25F , Sistema . Desenho . FontStyle . Sublinhado , Sistema . Desenho . GraphicsUnit . Ponto , (( byte ) ( 0 )));
            isso . lblGates . Localização  =  novo  sistema . Desenho . Ponto ( 17 , 252 );
            isso . lblGates . Nome  =  " lblGates " ;
            isso . lblGates . Tamanho  =  novo  sistema . Desenho . Tamanho ( 50 , 17 );
            isso . lblGates . TabIndex  =  39 ;
            isso . lblGates . Texto  =  " Gates: " ;
            // 
            // lblStatistics
            // 
            isso . lblStatistics . AutoSize  =  true ;
            isso . lblStatistics . Fonte  =  novo  sistema . Desenho . Fonte ( " Microsoft Sans Serif " , 10.25F , Sistema . Desenho . FontStyle . Sublinhado , Sistema . Desenho . GraphicsUnit . Ponto , (( byte ) ( 0 )));
            isso . lblStatistics . Localização  =  novo  sistema . Desenho . Ponto ( 510 , 112 );
            isso . lblStatistics . Nome  =  " lblStatistics " ;
            isso . lblStatistics . Tamanho  =  novo  sistema . Desenho . Tamanho ( 68 , 17 );
            isso . lblStatistics . TabIndex  =  38 ;
            isso . lblStatistics . Texto  =  " Estatísticas: " ;
            // 
            // lblAccountInfo
            // 
            isso . lblAccountInfo . AutoSize  =  true ;
            isso . lblAccountInfo . Fonte  =  novo  sistema . Desenho . Fonte ( " Microsoft Sans Serif " , 10.25F , Sistema . Desenho . FontStyle . Sublinhado , Sistema . Desenho . GraphicsUnit . Ponto , (( byte ) ( 0 )));
            isso . lblAccountInfo . Localização  =  novo  sistema . Desenho . Ponto ( 510 , 10 );
            isso . lblAccountInfo . Nome  =  " lblAccountInfo " ;
            isso . lblAccountInfo . Tamanho  =  novo  sistema . Desenho . Tamanho ( 90 , 17 );
            isso . lblAccountInfo . TabIndex  =  37 ;
            isso . lblAccountInfo . Texto  =  " Informações da conta: " ;
            // 
            // chkSpinOnlyEE
            // 
            isso . chkSpinOnlyEE . AutoSize  =  true ;
            isso . chkSpinOnlyEE . Localização  =  novo  sistema . Desenho . Ponto ( 20 , 73 );
            isso . chkSpinOnlyEE . Nome  =  " chkSpinOnlyEE " ;
            isso . chkSpinOnlyEE . Tamanho  =  novo  sistema . Desenho . Tamanho ( 86 , 17 );
            isso . chkSpinOnlyEE . TabIndex  =  34 ;
            isso . chkSpinOnlyEE . Texto  =  " Girar apenas EE " ;
            isso . chkSpinOnlyEE . UseVisualStyleBackColor  =  true ;
            // 
            // nudMinimumUridium
            // 
            isso . nudMinimumUridium . Incremento  =  novo  decimal ( new  int [] {
            1000 ,
            0 ,
            0 ,
            0 });
            isso . nudMinimumUridium . Localização  =  novo  sistema . Desenho . Ponto ( 81 , 209 );
            isso . nudMinimumUridium . Máximo  =  novo  decimal ( new  int [] {
            1000000 ,
            0 ,
            0 ,
            0 });
            isso . nudMinimumUridium . Nome  =  " nudMinimumUridium " ;
            isso . nudMinimumUridium . Tamanho  =  novo  sistema . Desenho . Tamanho ( 61 , 20 );
            isso . nudMinimumUridium . TabIndex  =  31 ;
            isso . nudMinimumUridium . Valor  =  novo  decimal ( new  int [] {
            1000000 ,
            0 ,
            0 ,
            0 });
            // 
            // lblMinimumUridium
            // 
            isso . lblMinimumUridium . AutoSize  =  true ;
            isso . lblMinimumUridium . Localização  =  novo  sistema . Desenho . Ponto ( 17 , 212 );
            isso . lblMinimumUridium . Nome  =  " lblMinimumUridium " ;
            isso . lblMinimumUridium . Tamanho  =  novo  sistema . Desenho . Tamanho ( 63 , 13 );
            isso . lblMinimumUridium . TabIndex  =  30 ;
            isso . lblMinimumUridium . Texto  =  " Uridium mínimo: " ;
            // 
            // chkBoxPlaceGate
            // 
            isso . chkBoxPlaceGate . AutoSize  =  true ;
            isso . chkBoxPlaceGate . Localização  =  novo  sistema . Desenho . Ponto ( 20 , 54 );
            isso . chkBoxPlaceGate . Nome  =  " chkBoxPlaceGate " ;
            isso . chkBoxPlaceGate . Tamanho  =  novo  sistema . Desenho . Tamanho ( 115 , 17 );
            isso . chkBoxPlaceGate . TabIndex  =  29 ;
            isso . chkBoxPlaceGate . Texto  =  " Colocar portão no mapa " ;
            isso . chkBoxPlaceGate . UseVisualStyleBackColor  =  true ;
            // 
            // chkBoxSpinGate
            // 
            isso . chkBoxSpinGate . AutoSize  =  true ;
            isso . chkBoxSpinGate . Localização  =  novo  sistema . Desenho . Ponto ( 20 , 33 );
            isso . chkBoxSpinGate . Nome  =  " chkBoxSpinGate " ;
            isso . chkBoxSpinGate . Tamanho  =  novo  sistema . Desenho . Tamanho ( 71 , 17 );
            isso . chkBoxSpinGate . TabIndex  =  28 ;
            isso . chkBoxSpinGate . Texto  =  " portão de rotação " ;
            isso . chkBoxSpinGate . UseVisualStyleBackColor  =  true ;
            // 
            // lblReceivedParts
            // 
            isso . lblReceivedParts . AutoSize  =  true ;
            isso . lblReceivedParts . Localização  =  novo  sistema . Desenho . Ponto ( 512 , 336 );
            isso . lblReceivedParts . Nome  =  " lblReceivedParts " ;
            isso . lblReceivedParts . Tamanho  =  novo  sistema . Desenho . Tamanho ( 34 , 13 );
            isso . lblReceivedParts . TabIndex  =  27 ;
            isso . lblReceivedParts . Texto  =  " Partes: " ;
            // 
            // nudGateDelay
            // 
            isso . nudGateDelay . Incremento  =  novo  decimal ( new  int [] {
            25 ,
            0 ,
            0 ,
            0 });
            isso . nudGateDelay . Localização  =  novo  sistema . Desenho . Ponto ( 20 , 140 );
            isso . nudGateDelay . Máximo  =  novo  decimal ( new  int [] {
            5000 ,
            0 ,
            0 ,
            0 });
            isso . nudGateDelay . Nome  =  " nudGateDelay " ;
            isso . nudGateDelay . Tamanho  =  novo  sistema . Desenho . Tamanho ( 50 , 20 );
            isso . nudGateDelay . TabIndex  =  26 ;
            isso . nudGateDelay . Valor  =  novo  decimal ( new  int [] {
            150 ,
            0 ,
            0 ,
            0 });
            // 
            // lblGateDelay
            // 
            isso . lblGateDelay . AutoSize  =  true ;
            isso . lblGateDelay . Localização  =  novo  sistema . Desenho . Ponto ( 70 , 143 );
            isso . lblGateDelay . Nome  =  " lblGateDelay " ;
            isso . lblGateDelay . Tamanho  =  novo  sistema . Desenho . Tamanho ( 56 , 13 );
            isso . lblGateDelay . TabIndex  =  25 ;
            isso . lblGateDelay . Texto  =  " Atraso (ms) " ;
            // 
            // lblSpinCost
            // 
            isso . lblSpinCost . AutoSize  =  true ;
            isso . lblSpinCost . Localização  =  novo  sistema . Desenho . Ponto ( 510 , 73 );
            isso . lblSpinCost . Nome  =  " lblSpinCost " ;
            isso . lblSpinCost . Tamanho  =  novo  sistema . Desenho . Tamanho ( 54 , 13 );
            isso . lblSpinCost . TabIndex  =  24 ;
            isso . lblSpinCost . Texto  =  " Custo de rotação: " ;
            // 
            // lblReceivedNanoHull
            // 
            isso . lblReceivedNanoHull . AutoSize  =  true ;
            isso . lblReceivedNanoHull . Localização  =  novo  sistema . Desenho . Ponto ( 510 , 292 );
            isso . lblReceivedNanoHull . Nome  =  " lblReceivedNanoHull " ;
            isso . lblReceivedNanoHull . Tamanho  =  novo  sistema . Desenho . Tamanho ( 55 , 13 );
            isso . lblReceivedNanoHull . TabIndex  =  23 ;
            isso . lblReceivedNanoHull . Texto  =  " Casco nano: " ;
            // 
            // lblReceivedXenomit
            // 
            isso . lblReceivedXenomit . AutoSize  =  true ;
            isso . lblReceivedXenomit . Localização  =  novo  sistema . Desenho . Ponto ( 512 , 382 );
            isso . lblReceivedXenomit . Nome  =  " lblReceivedXenomit " ;
            isso . lblReceivedXenomit . Tamanho  =  novo  sistema . Desenho . Tamanho ( 48 , 13 );
            isso . lblReceivedXenomit . TabIndex  =  22 ;
            isso . lblReceivedXenomit . Texto  =  " Xenomit: " ;
            // 
            // lblReceivedRepairCredits
            // 
            isso . lblReceivedRepairCredits . AutoSize  =  true ;
            isso . lblReceivedRepairCredits . Localização  =  novo  sistema . Desenho . Ponto ( 512 , 358 );
            isso . lblReceivedRepairCredits . Nome  =  " lblReceivedRepairCredits " ;
            isso . lblReceivedRepairCredits . Tamanho  =  novo  sistema . Desenho . Tamanho ( 75 , 13 );
            isso . lblReceivedRepairCredits . TabIndex  =  21 ;
            isso . lblReceivedRepairCredits . Texto  =  " Créditos de reparo: " ;
            // 
            // lblReceivedLogDisks
            // 
            isso . lblReceivedLogDisks . AutoSize  =  true ;
            isso . lblReceivedLogDisks . Localização  =  novo  sistema . Desenho . Ponto ( 512 , 313 );
            isso . lblReceivedLogDisks . Nome  =  " lblReceivedLogDisks " ;
            isso . lblReceivedLogDisks . Tamanho  =  novo  sistema . Desenho . Tamanho ( 55 , 13 );
            isso . lblReceivedLogDisks . TabIndex  =  20 ;
            isso . lblReceivedLogDisks . Texto  =  " Discos de log: " ;
            // 
            // lblReceivedACM
            // 
            isso . lblReceivedACM . AutoSize  =  true ;
            isso . lblReceivedACM . Localização  =  novo  sistema . Desenho . Ponto ( 510 , 273 );
            isso . lblReceivedACM . Nome  =  " lblReceivedACM " ;
            isso . lblReceivedACM . Tamanho  =  novo  sistema . Desenho . Tamanho ( 33 , 13 );
            isso . lblReceivedACM . TabIndex  =  19 ;
            isso . lblReceivedACM . Texto  =  " ACM: " ;
            // 
            // lblReceivedPLT2021
            // 
            isso . lblReceivedPLT2021 . AutoSize  =  true ;
            isso . lblReceivedPLT2021 . Localização  =  novo  sistema . Desenho . Ponto ( 510 , 252 );
            isso . lblReceivedPLT2021 . Nome  =  " lblReceivedPLT2021 " ;
            isso . lblReceivedPLT2021 . Tamanho  =  novo  sistema . Desenho . Tamanho ( 57 , 13 );
            isso . lblReceivedPLT2021 . TabIndex  =  18 ;
            isso . lblReceivedPLT2021 . Texto  =  " PLT-2021: " ;
            // 
            // lblReceivedSAB
            // 
            isso . lblReceivedSAB . AutoSize  =  true ;
            isso . lblReceivedSAB . Localização  =  novo  sistema . Desenho . Ponto ( 510 , 229 );
            isso . lblReceivedSAB . Nome  =  " lblReceivedSAB " ;
            isso . lblReceivedSAB . Tamanho  =  novo  sistema . Desenho . Tamanho ( 31 , 13 );
            isso . lblReceivedSAB . TabIndex  =  17 ;
            isso . lblReceivedSAB . Texto  =  " SAB: " ;
            // 
            // lblReceivedX4
            // 
            isso . lblReceivedX4 . AutoSize  =  true ;
            isso . lblReceivedX4 . Localização  =  novo  sistema . Desenho . Ponto ( 510 , 206 );
            isso . lblReceivedX4 . Nome  =  " lblReceivedX4 " ;
            isso . lblReceivedX4 . Tamanho  =  novo  sistema . Desenho . Tamanho ( 23 , 13 );
            isso . lblReceivedX4 . TabIndex  =  16 ;
            isso . lblReceivedX4 . Texto  =  " X4: " ;
            // 
            // lblReceivedX3
            // 
            isso . lblReceivedX3 . AutoSize  =  true ;
            isso . lblReceivedX3 . Localização  =  novo  sistema . Desenho . Ponto ( 510 , 183 );
            isso . lblReceivedX3 . Nome  =  " lblReceivedX3 " ;
            isso . lblReceivedX3 . Tamanho  =  novo  sistema . Desenho . Tamanho ( 23 , 13 );
            isso . lblReceivedX3 . TabIndex  =  15 ;
            isso . lblReceivedX3 . Texto  =  " X3: " ;
            // 
            // lblReceivedX2
            // 
            isso . lblReceivedX2 . AutoSize  =  true ;
            isso . lblReceivedX2 . Localização  =  novo  sistema . Desenho . Ponto ( 510 , 160 );
            isso . lblReceivedX2 . Nome  =  " lblReceivedX2 " ;
            isso . lblReceivedX2 . Tamanho  =  novo  sistema . Desenho . Tamanho ( 23 , 13 );
            isso . lblReceivedX2 . TabIndex  =  14 ;
            isso . lblReceivedX2 . Texto  =  " X2: " ;
            // 
            // lblTotalSpins
            // 
            isso . lblTotalSpins . AutoSize  =  true ;
            isso . lblTotalSpins . Localização  =  novo  sistema . Desenho . Ponto ( 510 , 137 );
            isso . lblTotalSpins . Nome  =  " lblTotalSpins " ;
            isso . lblTotalSpins . Tamanho  =  novo  sistema . Desenho . Tamanho ( 62 , 13 );
            isso . lblTotalSpins . TabIndex  =  13 ;
            isso . lblTotalSpins . Text  =  " Rodadas usadas: " ;
            // 
            // lblExtraEnergy
            // 
            isso . lblExtraEnergy . AutoSize  =  true ;
            isso . lblExtraEnergy . Localização  =  novo  sistema . Desenho . Ponto ( 510 , 54 );
            isso . lblExtraEnergy . Nome  =  " lblExtraEnergy " ;
            isso . lblExtraEnergy . Tamanho  =  novo  sistema . Desenho . Tamanho ( 70 , 13 );
            isso . lblExtraEnergy . TabIndex  =  12 ;
            isso . lblExtraEnergy . Texto  =  " Energia Extra: " ;
            // 
            // lblUridium
            // 
            isso . lblUridium . AutoSize  =  true ;
            isso . lblUridium . Localização  =  novo  sistema . Desenho . Ponto ( 510 , 35 );
            isso . lblUridium . Nome  =  " lblUridium " ;
            isso . lblUridium . Tamanho  =  novo  sistema . Desenho . Tamanho ( 45 , 13 );
            isso . lblUridium . TabIndex  =  11 ;
            isso . lblUridium . Texto  =  " Uridium: " ;
            // 
            // dgvGates
            // 
            isso . dgvGates . AllowUserToAddRows  =  false ;
            isso . dgvGates . AllowUserToDeleteRows  =  false ;
            isso . dgvGates . AllowUserToResizeColumns  =  false ;
            isso . dgvGates . AllowUserToResizeRows  =  false ;
            isso . dgvGates . BackgroundColor  =  Sistema . Desenho . SystemColors . Controle ;
            isso . dgvGates . CausesValidation  =  false ;
            isso . dgvGates . ColumnHeadersHeightSizeMode  =  Sistema . Windows . Formulários . DataGridViewColumnHeadersHeightSizeMode . AutoSize ;
            isso . dgvGates . Colunas . AddRange ( novo  sistema . Windows . Formulários . DataGridViewColumn [] {
            isso . clmnGateName ,
            isso . clmnGateParts ,
            isso . clmnGateReady ,
            isso . clmnGateOnMap ,
            isso . clmnGatesBuilt });
            isso . dgvGates . Localização  =  novo  sistema . Desenho . Ponto ( 148 , 7 );
            isso . dgvGates . Nome  =  " dgvGates " ;
            isso . dgvGates . RowHeadersVisible  =  false ;
            isso . dgvGates . ShowCellErrors  =  false ;
            isso . dgvGates . ShowCellToolTips  =  false ;
            isso . dgvGates . ShowEditingIcon  =  false ;
            isso . dgvGates . ShowRowErrors  =  false ;
            isso . dgvGates . Tamanho  =  novo  sistema . Desenho . Tamanho ( 358 , 448 );
            isso . dgvGates . TabIndex  =  10 ;
            isso . dgvGates . SelectionChanged  + =  novo  sistema . EventHandler ( este . DataGridView_SelectionChanged );
            // 
            // clmnGateName
            // 
            isso . clmnGateName . Congelado  =  verdadeiro ;
            isso . clmnGateName . HeaderText  =  " Nome " ;
            isso . clmnGateName . Nome  =  " clmnGateName " ;
            isso . clmnGateName . ReadOnly  =  true ;
            isso . clmnGateName . Largura  =  60 ;
            // 
            // clmnGateParts
            // 
            isso . clmnGateParts . HeaderText  =  " Peças " ;
            isso . clmnGateParts . Nome  =  " clmnGateParts " ;
            isso . clmnGateParts . ReadOnly  =  true ;
            isso . clmnGateParts . Largura  =  70 ;
            // 
            // clmnGateReady
            // 
            isso . clmnGateReady . HeaderText  =  " Pronto " ;
            isso . clmnGateReady . Nome  =  " clmnGateReady " ;
            isso . clmnGateReady . ReadOnly  =  true ;
            isso . clmnGateReady . Largura  =  70 ;
            // 
            // clmnGateOnMap
            // 
            isso . clmnGateOnMap . HeaderText  =  " No mapa " ;
            isso . clmnGateOnMap . Nome  =  " clmnGateOnMap " ;
            isso . clmnGateOnMap . ReadOnly  =  true ;
            isso . clmnGateOnMap . Largura  =  70 ;
            // 
            // clmnGatesBuilt
            // 
            isso . clmnGatesBuilt . HeaderText  =  " Portões construídos " ;
            isso . clmnGatesBuilt . Nome  =  " clmnGatesBuilt " ;
            isso . clmnGatesBuilt . ReadOnly  =  true ;
            isso . clmnGatesBuilt . Largura  =  85 ;
            // 
            // cmdResetGateStats
            // 
            isso . cmdResetGateStats . Localização  =  novo  sistema . Desenho . Ponto ( 515 , 398 );
            isso . cmdResetGateStats . Nome  =  " cmdResetGateStats " ;
            isso . cmdResetGateStats . Tamanho  =  novo  sistema . Desenho . Tamanho ( 238 , 23 );
            isso . cmdResetGateStats . TabIndex  =  9 ;
            isso . cmdResetGateStats . Texto  =  " & Redefinir estatísticas " ;
            isso . cmdResetGateStats . UseVisualStyleBackColor  =  true ;
            isso . cmdResetGateStats . Clique em  + =  novo  sistema . EventHandler ( este . CmdResetGateStats_Click );
            // 
            // rbBuildKuiper
            // 
            isso . rbBuildKuiper . AutoSize  =  true ;
            isso . rbBuildKuiper . Localização  =  novo  sistema . Desenho . Ponto ( 20 , 438 );
            isso . rbBuildKuiper . Nome  =  " rbBuildKuiper " ;
            isso . rbBuildKuiper . Tamanho  =  novo  sistema . Desenho . Tamanho ( 55 , 17 );
            isso . rbBuildKuiper . TabIndex  =  8 ;
            isso . rbBuildKuiper . Texto  =  " Kuiper " ;
            isso . rbBuildKuiper . UseVisualStyleBackColor  =  true ;
            // 
            // rbBuildHades
            // 
            isso . rbBuildHades . AutoSize  =  true ;
            isso . rbBuildHades . Localização  =  novo  sistema . Desenho . Ponto ( 20 , 415 );
            isso . rbBuildHades . Nome  =  " rbBuildHades " ;
            isso . rbBuildHades . Tamanho  =  novo  sistema . Desenho . Tamanho ( 56 , 17 );
            isso . rbBuildHades . TabIndex  =  7 ;
            isso . rbBuildHades . Texto  =  " Hades " ;
            isso . rbBuildHades . UseVisualStyleBackColor  =  true ;
            // 
            // rbBuildKappa
            // 
            isso . rbBuildKappa . AutoSize  =  true ;
            isso . rbBuildKappa . Localização  =  novo  sistema . Desenho . Ponto ( 20 , 369 );
            isso . rbBuildKappa . Nome  =  " rbBuildKappa " ;
            isso . rbBuildKappa . Tamanho  =  novo  sistema . Desenho . Tamanho ( 56 , 17 );
            isso . rbBuildKappa . TabIndex  =  6 ;
            isso . rbBuildKappa . Texto  =  " Kappa " ;
            isso . rbBuildKappa . UseVisualStyleBackColor  =  true ;
            // 
            // rbBuildLambda
            // 
            isso . rbBuildLambda . AutoSize  =  true ;
            isso . rbBuildLambda . Localização  =  novo  sistema . Desenho . Ponto ( 20 , 392 );
            isso . rbBuildLambda . Nome  =  " rbBuildLambda " ;
            isso . rbBuildLambda . Tamanho  =  novo  sistema . Desenho . Tamanho ( 63 , 17 );
            isso . rbBuildLambda . TabIndex  =  5 ;
            isso . rbBuildLambda . Texto  =  " Lambda " ;
            isso . rbBuildLambda . UseVisualStyleBackColor  =  true ;
            // 
            // rbBuildZeta
            // 
            isso . rbBuildZeta . AutoSize  =  true ;
            isso . rbBuildZeta . Localização  =  novo  sistema . Desenho . Ponto ( 20 , 346 );
            isso . rbBuildZeta . Nome  =  " rbBuildZeta " ;
            isso . rbBuildZeta . Tamanho  =  novo  sistema . Desenho . Tamanho ( 47 , 17 );
            isso . rbBuildZeta . TabIndex  =  4 ;
            isso . rbBuildZeta . Texto  =  " Zeta " ;
            isso . rbBuildZeta . UseVisualStyleBackColor  =  true ;
            // 
            // rbBuildEpsilon
            // 
            isso . rbBuildEpsilon . AutoSize  =  true ;
            isso . rbBuildEpsilon . Localização  =  novo  sistema . Desenho . Ponto ( 20 , 323 );
            isso . rbBuildEpsilon . Nome  =  " rbBuildEpsilon " ;
            isso . rbBuildEpsilon . Tamanho  =  novo  sistema . Desenho . Tamanho ( 59 , 17 );
            isso . rbBuildEpsilon . TabIndex  =  3 ;
            isso . rbBuildEpsilon . Texto  =  " Epsilon " ;
            isso . rbBuildEpsilon . UseVisualStyleBackColor  =  true ;
            // 
            // rbBuildDelta
            // 
            isso . rbBuildDelta . AutoSize  =  true ;
            isso . rbBuildDelta . Localização  =  novo  sistema . Desenho . Ponto ( 20 , 300 );
            isso . rbBuildDelta . Nome  =  " rbBuildDelta " ;
            isso . rbBuildDelta . Tamanho  =  novo  sistema . Desenho . Tamanho ( 50 , 17 );
            isso . rbBuildDelta . TabIndex  =  2 ;
            isso . rbBuildDelta . Texto  =  " Delta " ;
            isso . rbBuildDelta . UseVisualStyleBackColor  =  true ;
            // 
            // rbBuildABG
            // 
            isso . rbBuildABG . AutoSize  =  true ;
            isso . rbBuildABG . Verificado  =  verdadeiro ;
            isso . rbBuildABG . Localização  =  novo  sistema . Desenho . Ponto ( 20 , 277 );
            isso . rbBuildABG . Nome  =  " rbBuildABG " ;
            isso . rbBuildABG . Tamanho  =  novo  sistema . Desenho . Tamanho ( 47 , 17 );
            isso . rbBuildABG . TabIndex  =  33 ;
            isso . rbBuildABG . TabStop  =  verdadeiro ;
            isso . rbBuildABG . Texto  =  " ABG " ;
            isso . rbBuildABG . UseVisualStyleBackColor  =  true ;
            isso . rbBuildABG . CheckedChanged  + =  novo  sistema . EventHandler ( este . RbBuildABG_CheckedChanged );
            // 
            // tabPageTechFactory
            // 
            isso . tabPageTechFactory . Controles . Add ( este . NudCheckTechFactoryEvery );
            isso . tabPageTechFactory . Controles . Adicionar ( este . LblCheckTechFactoryEvery );
            isso . tabPageTechFactory . Controles . Adicionar ( este . ChkBoxBuildTechs );
            isso . tabPageTechFactory . Controles . Adicionar ( este . DgvTechFactory );
            isso . tabPageTechFactory . Localização  =  novo  sistema . Desenho . Ponto ( 4 , 22 );
            isso . tabPageTechFactory . Nome  =  " tabPageTechFactory " ;
            isso . tabPageTechFactory . Tamanho  =  novo  sistema . Desenho . Tamanho ( 767 , 458 );
            isso . tabPageTechFactory . TabIndex  =  2 ;
            isso . tabPageTechFactory . Texto  =  " Fábrica de tecnologia " ;
            isso . tabPageTechFactory . UseVisualStyleBackColor  =  true ;
            // 
            // nudCheckTechFactoryEvery
            // 
            isso . nudCheckTechFactoryEvery . Localização  =  novo  sistema . Desenho . Ponto ( 256 , 9 );
            isso . nudCheckTechFactoryEvery . Máximo  =  novo  decimal ( new  int [] {
            168 ,
            0 ,
            0 ,
            0 });
            isso . nudCheckTechFactoryEvery . Mínimo  =  novo  decimal ( new  int [] {
            1 ,
            0 ,
            0 ,
            0 });
            isso . nudCheckTechFactoryEvery . Nome  =  " nudCheckTechFactoryEvery " ;
            isso . nudCheckTechFactoryEvery . Tamanho  =  novo  sistema . Desenho . Tamanho ( 54 , 20 );
            isso . nudCheckTechFactoryEvery . TabIndex  =  3 ;
            isso . nudCheckTechFactoryEvery . Valor  =  novo  decimal ( new  int [] {
            10 ,
            0 ,
            0 ,
            0 });
            // 
            // lblCheckTechFactoryEvery
            // 
            isso . lblCheckTechFactoryEvery . AutoSize  =  true ;
            isso . lblCheckTechFactoryEvery . Localização  =  novo  sistema . Desenho . Ponto ( 124 , 11 );
            isso . lblCheckTechFactoryEvery . Nome  =  " lblCheckTechFactoryEvery " ;
            isso . lblCheckTechFactoryEvery . Tamanho  =  novo  sistema . Desenho . Tamanho ( 229 , 13 );
            isso . lblCheckTechFactoryEvery . TabIndex  =  4 ;
            isso . lblCheckTechFactoryEvery . Text  =  " Verifique a Tech Factory a cada minuto " ;
            // 
            // chkBoxBuildTechs
            // 
            isso . chkBoxBuildTechs . AutoSize  =  true ;
            isso . chkBoxBuildTechs . Localização  =  novo  sistema . Desenho . Ponto ( 20 , 10 );
            isso . chkBoxBuildTechs . Nome  =  " chkBoxBuildTechs " ;
            isso . chkBoxBuildTechs . Tamanho  =  novo  sistema . Desenho . Tamanho ( 78 , 17 );
            isso . chkBoxBuildTechs . TabIndex  =  2 ;
            isso . chkBoxBuildTechs . Texto  =  " Construir técnicos " ;
            isso . chkBoxBuildTechs . UseVisualStyleBackColor  =  true ;
            // 
            // dgvTechFactory
            // 
            isso . dgvTechFactory . AllowUserToAddRows  =  false ;
            isso . dgvTechFactory . AllowUserToDeleteRows  =  false ;
            isso . dgvTechFactory . AllowUserToResizeColumns  =  false ;
            isso . dgvTechFactory . AllowUserToResizeRows  =  false ;
            isso . dgvTechFactory . BackgroundColor  =  Sistema . Desenho . SystemColors . Controle ;
            isso . dgvTechFactory . ColumnHeadersHeightSizeMode  =  Sistema . Windows . Formulários . DataGridViewColumnHeadersHeightSizeMode . AutoSize ;
            isso . dgvTechFactory . Colunas . AddRange ( novo  sistema . Windows . Formulários . DataGridViewColumn [] {
            isso . clmnTechName ,
            isso . clmnTechAmount ,
            isso . clmnTechBuilding ,
            isso . clmnTechTimeLeft ,
            isso . clmnTechBuild });
            isso . dgvTechFactory . Localização  =  novo  sistema . Desenho . Ponto ( 20 , 33 );
            isso . dgvTechFactory . Nome  =  " dgvTechFactory " ;
            isso . dgvTechFactory . RowHeadersVisible  =  false ;
            isso . dgvTechFactory . ShowCellErrors  =  false ;
            isso . dgvTechFactory . ShowCellToolTips  =  false ;
            isso . dgvTechFactory . ShowEditingIcon  =  false ;
            isso . dgvTechFactory . ShowRowErrors  =  false ;
            isso . dgvTechFactory . Tamanho  =  novo  sistema . Desenho . Tamanho ( 443 , 278 );
            isso . dgvTechFactory . TabIndex  =  1 ;
            isso . dgvTechFactory . CurrentCellDirtyStateChanged  + =  novo  sistema . EventHandler ( this . DataGridView_CurrentCellDirtyStateChanged );
            isso . dgvTechFactory . SelectionChanged  + =  novo  sistema . EventHandler ( este . DataGridView_SelectionChanged );
            // 
            // clmnTechName
            // 
            isso . clmnTechName . HeaderText  =  " Tecnologia " ;
            isso . clmnTechName . Nome  =  " clmnTechName " ;
            isso . clmnTechName . ReadOnly  =  true ;
            isso . clmnTechName . Redimensionável  =  Sistema . Windows . Formulários . DataGridViewTriState . Falso ;
            isso . clmnTechName . SortMode  =  Sistema . Windows . Formulários . DataGridViewColumnSortMode . NotSortable ;
            isso . clmnTechName . Largura  =  120 ;
            // 
            // clmnTechAmount
            // 
            isso . clmnTechAmount . HeaderText  =  " Valor " ;
            isso . clmnTechAmount . Nome  =  " clmnTechAmount " ;
            isso . clmnTechAmount . ReadOnly  =  true ;
            isso . clmnTechAmount . Redimensionável  =  Sistema . Windows . Formulários . DataGridViewTriState . Falso ;
            isso . clmnTechAmount . SortMode  =  Sistema . Windows . Formulários . DataGridViewColumnSortMode . NotSortable ;
            isso . clmnTechAmount . Largura  =  70 ;
            // 
            // clmnTechBuilding
            // 
            isso . clmnTechBuilding . HeaderText  =  " Edifício " ;
            isso . clmnTechBuilding . Nome  =  " clmnTechBuilding " ;
            isso . clmnTechBuilding . ReadOnly  =  true ;
            isso . clmnTechBuilding . Redimensionável  =  Sistema . Windows . Formulários . DataGridViewTriState . Falso ;
            isso . clmnTechBuilding . Largura  =  80 ;
            // 
            // clmnTechTimeLeft
            // 
            isso . clmnTechTimeLeft . HeaderText  =  " Tempo restante " ;
            isso . clmnTechTimeLeft . Nome  =  " clmnTechTimeLeft " ;
            isso . clmnTechTimeLeft . ReadOnly  =  true ;
            isso . clmnTechTimeLeft . Redimensionável  =  Sistema . Windows . Formulários . DataGridViewTriState . Falso ;
            isso . clmnTechTimeLeft . SortMode  =  Sistema . Windows . Formulários . DataGridViewColumnSortMode . NotSortable ;
            // 
            // clmnTechBuild
            // 
            isso . clmnTechBuild . HeaderText  =  " Compilar " ;
            isso . clmnTechBuild . Nome  =  " clmnTechBuild " ;
            isso . clmnTechBuild . Redimensionável  =  Sistema . Windows . Formulários . DataGridViewTriState . Falso ;
            isso . clmnTechBuild . Largura  =  70 ;
            // 
            // tabPageSkylab
            // 
            isso . tabPageSkylab . Controles . Adicionar ( este . NudCheckSkylabEvery );
            isso . tabPageSkylab . Controles . Adicionar ( este . LblCheckSkylabEvery );
            isso . tabPageSkylab . Controles . Adicionar ( este . ChkBoxUpgradeSkylab );
            isso . tabPageSkylab . Controles . Adicionar ( este . DgvSkylab );
            isso . tabPageSkylab . Localização  =  novo  sistema . Desenho . Ponto ( 4 , 22 );
            isso . tabPageSkylab . Nome  =  " tabPageSkylab " ;
            isso . tabPageSkylab . Tamanho  =  novo  sistema . Desenho . Tamanho ( 767 , 458 );
            isso . tabPageSkylab . TabIndex  =  3 ;
            isso . tabPageSkylab . Texto  =  " Skylab " ;
            isso . tabPageSkylab . UseVisualStyleBackColor  =  true ;
            // 
            // nudCheckSkylabEvery
            // 
            isso . nudCheckSkylabEvery . Localização  =  novo  sistema . Desenho . Ponto ( 226 , 9 );
            isso . nudCheckSkylabEvery . Máximo  =  novo  decimal ( new  int [] {
            168 ,
            0 ,
            0 ,
            0 });
            isso . nudCheckSkylabEvery . Mínimo  =  novo  decimal ( new  int [] {
            1 ,
            0 ,
            0 ,
            0 });
            isso . nudCheckSkylabEvery . Nome  =  " nudCheckSkylabEvery " ;
            isso . nudCheckSkylabEvery . Tamanho  =  novo  sistema . Desenho . Tamanho ( 54 , 20 );
            isso . nudCheckSkylabEvery . TabIndex  =  5 ;
            isso . nudCheckSkylabEvery . Valor  =  novo  decimal ( new  int [] {
            10 ,
            0 ,
            0 ,
            0 });
            // 
            // lblCheckSkylabEvery
            // 
            isso . lblCheckSkylabEvery . AutoSize  =  true ;
            isso . lblCheckSkylabEvery . Localização  =  novo  sistema . Desenho . Ponto ( 124 , 11 );
            isso . lblCheckSkylabEvery . Nome  =  " lblCheckSkylabEvery " ;
            isso . lblCheckSkylabEvery . Tamanho  =  novo  sistema . Desenho . Tamanho ( 198 , 13 );
            isso . lblCheckSkylabEvery . TabIndex  =  6 ;
            isso . lblCheckSkylabEvery . Text  =  " Verifique o Skylab a cada minuto " ;
            // 
            // chkBoxUpgradeSkylab
            // 
            isso . chkBoxUpgradeSkylab . AutoSize  =  true ;
            isso . chkBoxUpgradeSkylab . Localização  =  novo  sistema . Desenho . Ponto ( 20 , 10 );
            isso . chkBoxUpgradeSkylab . Nome  =  " chkBoxUpgradeSkylab " ;
            isso . chkBoxUpgradeSkylab . Tamanho  =  novo  sistema . Desenho . Tamanho ( 100 , 17 );
            isso . chkBoxUpgradeSkylab . TabIndex  =  3 ;
            isso . chkBoxUpgradeSkylab . Texto  =  " Atualizar skylab " ;
            isso . chkBoxUpgradeSkylab . UseVisualStyleBackColor  =  true ;
            // 
            // dgvSkylab
            // 
            isso . dgvSkylab . AllowUserToAddRows  =  false ;
            isso . dgvSkylab . AllowUserToDeleteRows  =  false ;
            isso . dgvSkylab . AllowUserToResizeColumns  =  false ;
            isso . dgvSkylab . AllowUserToResizeRows  =  false ;
            isso . dgvSkylab . BackgroundColor  =  Sistema . Desenho . SystemColors . Controle ;
            isso . dgvSkylab . CausesValidation  =  false ;
            isso . dgvSkylab . ColumnHeadersHeightSizeMode  =  Sistema . Windows . Formulários . DataGridViewColumnHeadersHeightSizeMode . AutoSize ;
            isso . dgvSkylab . Colunas . AddRange ( novo  sistema . Windows . Formulários . DataGridViewColumn [] {
            isso . clmnModuleName ,
            isso . clmnModuleLevel ,
            isso . clmnModuleUpgrading ,
            isso . clmnModuleTimeLeft ,
            isso . clmnModuleUpgrade });
            isso . dgvSkylab . Localização  =  novo  sistema . Desenho . Ponto ( 20 , 33 );
            isso . dgvSkylab . Nome  =  " dgvSkylab " ;
            isso . dgvSkylab . RowHeadersVisible  =  false ;
            isso . dgvSkylab . ShowCellErrors  =  false ;
            isso . dgvSkylab . ShowCellToolTips  =  false ;
            isso . dgvSkylab . ShowEditingIcon  =  false ;
            isso . dgvSkylab . ShowRowErrors  =  false ;
            isso . dgvSkylab . Tamanho  =  novo  sistema . Desenho . Tamanho ( 543 , 279 );
            isso . dgvSkylab . TabIndex  =  0 ;
            isso . dgvSkylab . CurrentCellDirtyStateChanged  + =  novo  sistema . EventHandler ( this . DataGridView_CurrentCellDirtyStateChanged );
            isso . dgvSkylab . SelectionChanged  + =  novo  sistema . EventHandler ( este . DataGridView_SelectionChanged );
            // 
            // clmnModuleName
            // 
            isso . clmnModuleName . HeaderText  =  " Módulo " ;
            isso . clmnModuleName . Nome  =  " clmnModuleName " ;
            isso . clmnModuleName . ReadOnly  =  true ;
            isso . clmnModuleName . Redimensionável  =  Sistema . Windows . Formulários . DataGridViewTriState . Falso ;
            isso . clmnModuleName . SortMode  =  Sistema . Windows . Formulários . DataGridViewColumnSortMode . NotSortable ;
            isso . clmnModuleName . Largura  =  200 ;
            // 
            // clmnModuleLevel
            // 
            isso . clmnModuleLevel . HeaderText  =  " Nível " ;
            isso . clmnModuleLevel . Nome  =  " clmnModuleLevel " ;
            isso . clmnModuleLevel . ReadOnly  =  true ;
            isso . clmnModuleLevel . Redimensionável  =  Sistema . Windows . Formulários . DataGridViewTriState . Falso ;
            isso . clmnModuleLevel . SortMode  =  Sistema . Windows . Formulários . DataGridViewColumnSortMode . NotSortable ;
            isso . clmnModuleLevel . Largura  =  70 ;
            // 
            // clmnModuleUpgrading
            // 
            isso . clmnModuleUpgrading . HeaderText  =  " Atualizando " ;
            isso . clmnModuleUpgrading . Nome  =  " clmnModuleUpgrading " ;
            isso . clmnModuleUpgrading . ReadOnly  =  true ;
            isso . clmnModuleUpgrading . Redimensionável  =  Sistema . Windows . Formulários . DataGridViewTriState . Falso ;
            isso . clmnModuleUpgrading . Largura  =  80 ;
            // 
            // clmnModuleTimeLeft
            // 
            isso . clmnModuleTimeLeft . HeaderText  =  " Tempo restante " ;
            isso . clmnModuleTimeLeft . Nome  =  " clmnModuleTimeLeft " ;
            isso . clmnModuleTimeLeft . ReadOnly  =  true ;
            isso . clmnModuleTimeLeft . Largura  =  120 ;
            // 
            // clmnModuleUpgrade
            // 
            isso . clmnModuleUpgrade . HeaderText  =  " Atualização " ;
            isso . clmnModuleUpgrade . Nome  =  " clmnModuleUpgrade " ;
            isso . clmnModuleUpgrade . Redimensionável  =  Sistema . Windows . Formulários . DataGridViewTriState . Falso ;
            isso . clmnModuleUpgrade . Largura  =  70 ;
            // 
            // tabPageLog
            // 
            isso . tabPageLog . Controles . Adicionar ( este . RtbLog );
            isso . tabPageLog . Localização  =  novo  sistema . Desenho . Ponto ( 4 , 22 );
            isso . tabPageLog . Nome  =  " tabPageLog " ;
            isso . tabPageLog . Preenchimento  =  novo  sistema . Windows . Formulários . Preenchimento ( 3 );
            isso . tabPageLog . Tamanho  =  novo  sistema . Desenho . Tamanho ( 767 , 458 );
            isso . tabPageLog . TabIndex  =  5 ;
            isso . tabPageLog . Texto  =  " Log " ;
            isso . tabPageLog . UseVisualStyleBackColor  =  true ;
            // 
            // rtbLog
            // 
            isso . rtbLog . Localização  =  novo  sistema . Desenho . Ponto ( 20 , 6 );
            isso . rtbLog . Nome  =  " rtbLog " ;
            isso . rtbLog . ReadOnly  =  true ;
            isso . rtbLog . Tamanho  =  novo  sistema . Desenho . Tamanho ( 728 , 347 );
            isso . rtbLog . TabIndex  =  0 ;
            isso . rtbLog . Texto  =  " " ;
            // 
            // cmdStart
            // 
            isso . cmdStart . Localização  =  novo  sistema . Desenho . Ponto ( 418 , 12 );
            isso . cmdStart . Nome  =  " cmdStart " ;
            isso . cmdStart . Tamanho  =  novo  sistema . Desenho . Tamanho ( 75 , 23 );
            isso . cmdStart . TabIndex  =  1 ;
            isso . cmdStart . Texto  =  " Iniciar " ;
            isso . cmdStart . UseVisualStyleBackColor  =  true ;
            isso . cmdStart . Clique em  + =  novo  sistema . EventHandler ( este . CmdStart_Click );
            // 
            // cmdStop
            // 
            isso . cmdStop . Localização  =  novo  sistema . Desenho . Ponto ( 499 , 12 );
            isso . cmdStop . Nome  =  " cmdStop " ;
            isso . cmdStop . Tamanho  =  novo  sistema . Desenho . Tamanho ( 75 , 23 );
            isso . cmdStop . TabIndex  =  2 ;
            isso . cmdStop . Texto  =  " Parar " ;
            isso . cmdStop . UseVisualStyleBackColor  =  true ;
            isso . cmdStop . Clique em  + =  novo  sistema . EventHandler ( este . CmdStop_Click );
            // 
            // cmdOpenBackPage
            // 
            isso . cmdOpenBackPage . Localização  =  novo  sistema . Desenho . Ponto ( 580 , 12 );
            isso . cmdOpenBackPage . Nome  =  " cmdOpenBackPage " ;
            isso . cmdOpenBackPage . Tamanho  =  novo  sistema . Desenho . Tamanho ( 97 , 23 );
            isso . cmdOpenBackPage . TabIndex  =  3 ;
            isso . cmdOpenBackPage . Texto  =  " Abrir página traseira " ;
            isso . cmdOpenBackPage . UseVisualStyleBackColor  =  true ;
            isso . cmdOpenBackPage . Clique em  + =  novo  sistema . EventHandler ( este . CmdOpenBackPage_Click );
            // 
            // lblLastStatus
            // 
            isso . lblLastStatus . AutoSize  =  true ;
            isso . lblLastStatus . Fonte  =  novo  sistema . Desenho . Fonte ( " Microsoft Sans Serif " , 9F , Sistema . Desenho . FontStyle . Regular , Sistema . Desenho . Unidade Gráfica . Ponto , (( byte ) ( 0 )));
            isso . lblLastStatus . Localização  =  novo  sistema . Desenho . Ponto ( 14 , 15 );
            isso . lblLastStatus . Nome  =  " lblLastStatus " ;
            isso . lblLastStatus . Tamanho  =  novo  sistema . Desenho . Tamanho ( 71 , 15 );
            isso . lblLastStatus . TabIndex  =  4 ;
            isso . lblLastStatus . Texto  =  " Último status: " ;
            // 
            // cmdSaveSettings
            // 
            isso . cmdSaveSettings . Localização  =  novo  sistema . Desenho . Ponto ( 683 , 12 );
            isso . cmdSaveSettings . Nome  =  " cmdSaveSettings " ;
            isso . cmdSaveSettings . Tamanho  =  novo  sistema . Desenho . Tamanho ( 101 , 23 );
            isso . cmdSaveSettings . TabIndex  =  5 ;
            isso . cmdSaveSettings . Texto  =  " Salvar configurações " ;
            isso . cmdSaveSettings . UseVisualStyleBackColor  =  true ;
            isso . cmdSaveSettings . Clique em  + =  novo  sistema . EventHandler ( este . CmdSaveSettings_Click );
            // 
            // notifyIcon1
            // 
            isso . notifyIcon1 . Texto  =  " Corvus - Auxiliar de Bot do DarkOrbit " ;
            isso . notifyIcon1 . Visível  =  verdadeiro ;
            // 
            // FrmMain
            // 
            isso . AutoScaleDimensions  =  novo  sistema . Desenho . TamanhoF ( 6F , 13F );
            isso . AutoScaleMode  =  Sistema . Windows . Formulários . AutoScaleMode . Fonte ;
            isso . ClientSize  =  novo  sistema . Desenho . Tamanho ( 801 , 535 );
            isso . Controles . Adicionar ( este . CmdSaveSettings );
            isso . Controles . Adicionar ( este . LblLastStatus );
            isso . Controles . Adicionar ( este . CmdOpenBackPage );
            isso . Controles . Adicionar ( este . CmdStop );
            isso . Controles . Adicionar ( este . CmdStart );
            isso . Controles . Adicionar ( este . TcMain );
            isso . DoubleBuffered  =  true ;
            isso . FormBorderStyle  =  Sistema . Windows . Formulários . FormBorderStyle . FixedDialog ;
            isso . Icon  = (( Sistema . Desenho . Ícone ) ( recursos . GetObject ( " $ this.Icon " )));
            isso . MaximizeBox  =  false ;
            isso . Nome  =  " FrmMain " ;
            isso . StartPosition  =  Sistema . Windows . Formulários . FormStartPosition . CenterScreen ;
            isso . Texto  =  " Corvus - Auxiliar de Bot do DarkOrbit " ;
            isso . FormClosing  + =  novo  sistema . Windows . Formulários . FormClosingEventHandler ( this . FrmMain_FormClosing );
            isso . tcMain . ResumeLayout ( false );
            isso . tabPageLogin . ResumeLayout ( false );
            isso . gBoxGeneralSettings . ResumeLayout ( false );
            isso . gBoxGeneralSettings . PerformLayout ();
            isso . gBoxUsernamePasswordLogin . ResumeLayout ( false );
            isso . gBoxUsernamePasswordLogin . PerformLayout ();
            isso . gBoxSessionIDLogin . ResumeLayout ( false );
            isso . gBoxSessionIDLogin . PerformLayout ();
            isso . tabPageGalaxyGates . ResumeLayout ( false );
            isso . tabPageGalaxyGates . PerformLayout ();
            (( System . ComponentModel . ISupportInitialize ) ( este . NudMaxSpinCost )). EndInit ();
            (( System . ComponentModel . ISupportInitialize ) ( este . NudGateWait )). EndInit ();
            (( System . ComponentModel . ISupportInitialize ) ( este . NudMinimumUridium )). EndInit ();
            (( System . ComponentModel . ISupportInitialize ) ( este . NudGateDelay )). EndInit ();
            (( System . ComponentModel . ISupportInitialize ) ( este . DgvGates )). EndInit ();
            isso . tabPageTechFactory . ResumeLayout ( false );
            isso . tabPageTechFactory . PerformLayout ();
            (( System . ComponentModel . ISupportInitialize ) ( este . NudCheckTechFactoryEvery )). EndInit ();
            (( System . ComponentModel . ISupportInitialize ) ( este . DgvTechFactory )). EndInit ();
            isso . tabPageSkylab . ResumeLayout ( false );
            isso . tabPageSkylab . PerformLayout ();
            (( System . ComponentModel . ISupportInitialize ) ( este . NudCheckSkylabEvery )). EndInit ();
            (( System . ComponentModel . ISupportInitialize ) ( este . DgvSkylab )). EndInit ();
            isso . tabPageLog . ResumeLayout ( false );
            isso . ResumeLayout ( false );
            isso . PerformLayout ();

        }

        # endregion

        System.Windows.Forms privado . TabControl  tcMain ;
        System.Windows.Forms privado . TabPage  tabPageLogin ;
        System.Windows.Forms privado . GroupBox  gBoxUsernamePasswordLogin ;
        System.Windows.Forms privado . GroupBox  gBoxSessionIDLogin ;
        System.Windows.Forms privado . TextBox  txtSessionId ;
        System.Windows.Forms privado . Label  lblSessionId ;
        System.Windows.Forms privado . TextBox  txtServer ;
        System.Windows.Forms privado . Label  lblServer ;
        System.Windows.Forms privado . CheckBox  chkBoxReconnect ;
        System.Windows.Forms privado . TextBox  txtPassword ;
        System.Windows.Forms privado . Label  lblPassword ;
        System.Windows.Forms privado . TextBox  txtUsername ;
        System.Windows.Forms privado . Label  lblUsername ;
        System.Windows.Forms privado . Botão  cmdLogin ;
        System.Windows.Forms privado . RadioButton  rbUsernamePasswordLogin ;
        System.Windows.Forms privado . RadioButton  rbSessionIdLogin ;
        System.Windows.Forms privado . TabPage  tabPageGalaxyGates ;
        System.Windows.Forms privado . TabPage  tabPageTechFactory ;
        System.Windows.Forms privado . TabPage  tabPageSkylab ;
        System.Windows.Forms privado . Label  lblPortal ;
        System.Windows.Forms privado . ComboBox  comboBoxLoginPortal ;
        System.Windows.Forms privado . DataGridView  dgvSkylab ;
        System.Windows.Forms privado . TabPage  tabPageLog ;
        System.Windows.Forms privado . DataGridView  dgvTechFactory ;
        System.Windows.Forms privado . DataGridViewTextBoxColumn  clmnModuleName ;
        System.Windows.Forms privado . DataGridViewTextBoxColumn  clmnModuleLevel ;
        System.Windows.Forms privado . DataGridViewCheckBoxColumn  clmnModuleUpgrading ;
        System.Windows.Forms privado . DataGridViewTextBoxColumn  clmnModuleTimeLeft ;
        System.Windows.Forms privado . DataGridViewCheckBoxColumn  clmnModuleUpgrade ;
        System.Windows.Forms privado . Botão  cmdStart ;
        System.Windows.Forms privado . Botão  cmdStop ;
        System.Windows.Forms privado . Botão  cmdOpenBackPage ;
        System.Windows.Forms privado . RadioButton  rbBuildABG ;
        System.Windows.Forms privado . RadioButton  rbBuildKuiper ;
        System.Windows.Forms privado . RadioButton  rbBuildHades ;
        System.Windows.Forms privado . RadioButton  rbBuildKappa ;
        System.Windows.Forms privado . RadioButton  rbBuildLambda ;
        System.Windows.Forms privado . RadioButton  rbBuildZeta ;
        System.Windows.Forms privado . RadioButton  rbBuildEpsilon ;
        System.Windows.Forms privado . RadioButton  rbBuildDelta ;
        System.Windows.Forms privado . Botão  cmdResetGateStats ;
        System.Windows.Forms privado . DataGridView  dgvGates ;
        System.Windows.Forms privado . Label  lblExtraEnergy ;
        System.Windows.Forms privado . Etiqueta  lblUridium ;
        System.Windows.Forms privado . Label  lblReceivedLogDisks ;
        System.Windows.Forms privado . Label  lblReceivedACM ;
        System.Windows.Forms privado . Etiqueta  lblReceivedPLT2021 ;
        System.Windows.Forms privado . Label  lblReceivedSAB ;
        System.Windows.Forms privado . Etiqueta  lblReceivedX4 ;
        System.Windows.Forms privado . Etiqueta  lblReceivedX3 ;
        System.Windows.Forms privado . Etiqueta  lblReceivedX2 ;
        System.Windows.Forms privado . Label  lblTotalSpins ;
        System.Windows.Forms privado . Label  lblSpinCost ;
        System.Windows.Forms privado . Label  lblReceivedNanoHull ;
        System.Windows.Forms privado . Label  lblReceivedXenomit ;
        System.Windows.Forms privado . Label  lblReceivedRepairCredits ;
        System.Windows.Forms privado . NumericUpDown  nudGateDelay ;
        System.Windows.Forms privado . Label  lblGateDelay ;
        System.Windows.Forms privado . Label  lblReceivedParts ;
        System.Windows.Forms privado . CheckBox  chkBoxSpinGate ;
        System.Windows.Forms privado . CheckBox  chkBoxPlaceGate ;
        System.Windows.Forms privado . NumericUpDown  nudMinimumUridium ;
        System.Windows.Forms privado . Etiqueta  lblMinimumUridium ;
        System.Windows.Forms privado . DataGridViewTextBoxColumn  clmnTechName ;
        System.Windows.Forms privado . DataGridViewTextBoxColumn  clmnTechAmount ;
        System.Windows.Forms privado . DataGridViewCheckBoxColumn  clmnTechBuilding ;
        System.Windows.Forms privado . DataGridViewTextBoxColumn  clmnTechTimeLeft ;
        System.Windows.Forms privado . DataGridViewCheckBoxColumn  clmnTechBuild ;
        System.Windows.Forms privado . CheckBox  chkBoxBuildTechs ;
        System.Windows.Forms privado . CheckBox  chkBoxUpgradeSkylab ;
        System.Windows.Forms privado . RichTextBox  rtbLog ;
        private  CheckBox  chkBoxSaveUsernamePassword ;
         rótulo  privado lblLastStatus ;
         botão  privado cmdSaveSettings ;
        private  NumericUpDown  nudCheckTechFactoryEvery ;
        privado  etiqueta  lblCheckTechFactoryEvery ;
        private  NumericUpDown  nudCheckSkylabEvery ;
        privado  etiqueta  lblCheckSkylabEvery ;
        private  CheckBox  chkSpinOnlyEE ;
        private  label  lblStatistics ;
         rótulo  privado lblAccountInfo ;
        private  label  lblGates ;
        private  DataGridViewTextBoxColumn  clmnGateName ;
        private  DataGridViewTextBoxColumn  clmnGateParts ;
        private  DataGridViewCheckBoxColumn  clmnGateReady ;
        private  DataGridViewCheckBoxColumn  clmnGateOnMap ;
        private  DataGridViewTextBoxColumn  clmnGatesBuilt ;
        private  ComboBox  comboBoxOptionABG ;
         rótulo  privado lblWaitGate ;
        private  NumericUpDown  nudGateWait ;
        privado  NotifyIcon  notifyIcon1 ;
        private  GroupBox  gBoxGeneralSettings ;
        private  CheckBox  chkBoxHideName ;
        privado  etiqueta  lblAccount ;
        private  CheckBox  chkBoxStartAgainTaskDestroy ;
        private  CheckBox  chkBoxActivateTheNotification ;
        private  label  label1 ;
        private  label  lblMultiplier ;
        private  ComboBox  comboBoxMultiplier ;
        private  CheckBox  chkBoxSmartMultiplier ;
        private  CheckBox  chkBoxActLog ;
        privado  etiqueta  lblEnergyBoost ;
        private  ComboBox  comboBoxEnergyBoost ;
         rótulo  privado lblSettingsGates ;
        private  NumericUpDown  nudMaxSpinCost ;
        privado  etiqueta  lblMaxSpinCost ;
    }
}
