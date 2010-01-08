/*
 * Copyright 2009 Canonical Ltd.
 *
 * This program is free software: you can redistribute it and/or modify it
 * under the terms of the GNU General Public License version 3, as published
 * by the Free Software Foundation.
 *
 * This program is distributed in the hope that it will be useful, but
 * WITHOUT ANY WARRANTY; without even the implied warranties of
 * MERCHANTABILITY, SATISFACTORY QUALITY, or FITNESS FOR A PARTICULAR
 * PURPOSE.  See the GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License along
 * with this program.  If not, see <http://www.gnu.org/licenses/>.
 *
 * Authors:
 *   Cody Russell <cody.russell@canonical.com>
 */

using Gtk;
using AppIndicator;

public class IndicatorExample
{
        public static void Main ()
        {
                Application.Init ();

                Window win = new Window ("Test");
                win.Resize (200, 200);

                Label label = new Label ();
                label.Text = "Hello, world!";

                win.Add (label);

                ApplicationIndicator indicator = new ApplicationIndicator ("my-id",
                                                                           "my-name",
                                                                           Category.ApplicationStatus);

                indicator.Status = Status.Attention;

                Menu menu = new Menu ();
                menu.Append (new MenuItem ("Foo"));
                menu.Append (new MenuItem ("Bar"));

                indicator.Menu = menu;

                win.ShowAll ();

                Application.Run ();
        }
}