﻿using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.Dtos.Endereco
{
	public class UpdateEnderecoDto
	{
		public string Logradouro { get; set; }
		public string Bairro { get; set; }
		public int Numero { get; set; }
	}
}
