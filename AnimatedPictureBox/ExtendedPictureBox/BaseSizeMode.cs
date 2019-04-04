﻿// ***********************************************************************
// Assembly         : Zeroit.Framework.PictureBox
// Author           : ZEROIT
// Created          : 12-20-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-20-2018
// ***********************************************************************
// <copyright file="BaseSizeMode.cs" company="Zeroit Dev Technologies">
//    This program is for creating Image controls.
//    Copyright ©  2017  Zeroit Dev Technologies
//
//    This program is free software: you can redistribute it and/or modify
//    it under the terms of the GNU General Public License as published by
//    the Free Software Foundation, either version 3 of the License, or
//    (at your option) any later version.
//
//    This program is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//    GNU General Public License for more details.
//
//    You should have received a copy of the GNU General Public License
//    along with this program.  If not, see <https://www.gnu.org/licenses/>.
//
//    You can contact me at zeroitdevnet@gmail.com or zeroitdev@outlook.com
// </copyright>
// <summary></summary>
// ***********************************************************************


namespace Zeroit.Framework.PictureBox
{

    #region Eumeration BaseSizeMode

    /// <summary>
    /// Enumeration holding the modes how the 100% zoom size
    /// is calculated in an <see cref="ExtendedPictureBox"/>.
    /// </summary>
    public enum BaseSizeMode
    {
        /// <summary>
        /// Size is calculated so that the image fits into the view given normal orientation.
        /// </summary>
        Normal,
        /// <summary>
        /// Size is calculated so that the image always fits into the view no matter of the rotation.
        /// </summary>
        Enhanced,
        /// <summary>
        /// A <see cref="ExtendedPictureBox.Zoom"/> of 100 will show the image in its original size in this mode.
        /// </summary>
        Original
    }

    #endregion


}
