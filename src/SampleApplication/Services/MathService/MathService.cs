//-------------------------------------------------------------------------------
// <copyright file="MathService.cs" company="bbv Software Services AG">
//   Copyright (c) 2010 bbv Software Services AG
//   Author: Remo Gloor (remo.gloor@gmail.com)
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//       http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.
// </copyright>
//-------------------------------------------------------------------------------

namespace SampleApplication.Services.MathService
{
    /// <summary>
    /// A math service
    /// </summary>
    public class MathService : IMathService
    {
        private int currentNumber;

        /// <summary>
        /// Calculates the sum the specified summands.
        /// </summary>
        /// <param name="summand1">The summand 1.</param>
        /// <param name="summand2">The summand 2.</param>
        /// <returns>The sum of the summands.</returns>
        public int Add(int summand1, int summand2)
        {
            return summand1 + summand2;
        }

        /// <summary>
        /// Counts from 1 upwards. On each call the next number is returned.
        /// </summary>
        /// <returns></returns>
        public int Count()
        {
            return this.currentNumber++;
        }
    }
}