﻿using System.Collections.Generic;

/* $Id: ListIterator.cs 124 2010-02-18 19:56:58Z psoares33 $
*
*
* This file is part of the iText project.
* Copyright(c) 1998-2009 1T3XT BVBA
* Authors: Bruno Lowagie, Paulo Soares, et al.
*
* This program is free software; you can redistribute it and/or modify
* it under the terms of the GNU Affero General Public License version 3
* as published by the Free Software Foundation with the addition of the
* following permission added to Section 15 as permitted in Section 7(a):
* FOR ANY PART OF THE COVERED WORK IN WHICH THE COPYRIGHT IS OWNED BY 1T3XT,
* 1T3XT DISCLAIMS THE WARRANTY OF NON INFRINGEMENT OF THIRD PARTY RIGHTS.
*
* This program is distributed in the hope that it will be useful, but
* WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY
* or FITNESS FOR A PARTICULAR PURPOSE.
* See the GNU Affero General Public License for more details.
* You should have received a copy of the GNU Affero General Public License
* along with this program; if not, see http://www.gnu.org/licenses or write to
* the Free Software Foundation, Inc., 51 Franklin Street, Fifth Floor,
* Boston, MA, 02110-1301 USA, or download the license from the following URL:
* http://itextpdf.com/terms-of-use/
*
* The interactive user interfaces in modified source and object code versions
* of this program must display Appropriate Legal Notices, as required under
* Section 5 of the GNU Affero General Public License.
*
* In accordance with Section 7(b) of the GNU Affero General Public License,
* you must retain the producer line in every PDF that is created or manipulated
*/

namespace System.util
{
    /// <summary>
    /// Summary description for ListIterator.
    /// </summary>
    public class ListIterator<T>
    {
        List<T> col;
        int cursor = 0;
        int lastRet = -1;

        public ListIterator(List<T> col)
        {
            this.col = col;
        }

        public ListIterator(List<T> col, int index)
        {
            this.col = col.GetRange(index, col.Count - index);
        }

        public bool HasNext()
        {
            return cursor != col.Count;
        }

        public T Next()
        {
            T next = col[cursor];
            lastRet = cursor++;
            return next;
        }

        public T Previous()
        {
            int i = cursor - 1;
            T previous = col[i];
            lastRet = cursor = i;
            return previous;
        }

        public void Remove()
        {
            if (lastRet == -1)
                throw new InvalidOperationException();
            col.RemoveAt(lastRet);
            if (lastRet < cursor)
                cursor--;
            lastRet = -1;
        }
    }
}
