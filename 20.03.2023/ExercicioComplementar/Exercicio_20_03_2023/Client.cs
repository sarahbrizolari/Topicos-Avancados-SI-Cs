﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_20_03_2023
{
	public class Client : Person
	{	
		public int IdClient { get; set; }

		public FollowUp FollowUp { get; set; }

		public override string ToString()
		{
			return "Tipo de Conta: " + FollowUp + base.ToString();
		}
	}
}
