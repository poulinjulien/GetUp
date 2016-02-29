﻿// -----------------------------------------------------------------------
// <copyright file="App.xaml.cs" company="WebForAll">
//   Copyright © WebForAll. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
// <author>Julien Poulin</author>
// <date>26/03/2015</date>
// <project>GetUp.Desktop</project>
// <web>http://www.webforall.be</web>
// -----------------------------------------------------------------------

namespace GetUp.Desktop
{

  using System.Windows;

  public partial class App
  {

    protected override void OnExit(ExitEventArgs e)
    {
      Desktop.Properties.Settings.Default.Save();

      base.OnExit(e);
    }

  }

}