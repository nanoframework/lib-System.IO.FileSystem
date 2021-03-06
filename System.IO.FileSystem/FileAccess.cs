﻿//
// Copyright (c) .NET Foundation and Contributors
// See LICENSE file in the project root for full license information.
//

namespace System.IO
{
    /// <summary>
    /// Contains constants for specifying the access you want for a file.
    /// You can have Read, Write or ReadWrite access.
    /// </summary>
    [Flags]
    public enum FileAccess
    {
        /// <summary>
        /// Specifies read access to the file. Data can be read from the file and
        /// the file pointer can be moved. Combine with WRITE for read-write access.
        /// </summary>
        Read = 1,

        /// <summary>
        /// Specifies write access to the file. Data can be written to the file and
        /// the file pointer can be moved. Combine with READ for read-write access.
        /// </summary>
        Write = 2,

        /// <summary>
        /// Specifies read and write access to the file. Data can be written to the
        /// file and the file pointer can be moved. Data can also be read from the
        /// file.
        /// </summary>
        ReadWrite = 3,
    }
}
