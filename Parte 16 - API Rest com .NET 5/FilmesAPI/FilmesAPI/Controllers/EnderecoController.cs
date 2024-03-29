﻿using AutoMapper;
using FilmesAPI.Data;
using FilmesAPI.Data.Dtos.Cinema;
using FilmesAPI.Data.Dtos.Endereco;
using FilmesAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace FilmesAPI.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class EnderecoController : ControllerBase
	{
		private FilmeContext _context;
		private IMapper _mapper;

		public EnderecoController(FilmeContext context, IMapper mapper)
		{
			_context = context;
			_mapper = mapper;
		}

		[HttpPost]
		public IActionResult AdicionaEndereco([FromBody] UpdateEnderecoDto cinemaDto)
		{
			Endereco endereco = _mapper.Map<Endereco>(cinemaDto);

			_context.Enderecos.Add(endereco);
			_context.SaveChanges();
			return CreatedAtAction(nameof(RecuperarEnderecoPorId), new { Id = endereco.Id }, endereco);
		}

		[HttpGet]
		public IEnumerable<Endereco> RecuperarFilmes()
		{
			return _context.Enderecos;
		}

		[HttpGet("{id}")]
		public IActionResult RecuperarEnderecoPorId(int id)
		{
			var endereco = _context.Enderecos.FirstOrDefault(endereco => endereco.Id == id);
			if (endereco != null)
			{
				ReadEnderecoDto enderecoDto = _mapper.Map<ReadEnderecoDto>(endereco);
				return Ok(enderecoDto);
			}

			return NotFound();
		}

		[HttpPut("{id}")]
		public IActionResult AtualizaEndereco(int id, [FromBody] UpdateEnderecoDto enderecoDto)
		{
			Endereco endereco = _context.Enderecos.FirstOrDefault(endereco => endereco.Id == id);
			if (endereco == null)
			{
				return NotFound();
			}

			_mapper.Map(enderecoDto, endereco);
			_context.SaveChanges();
			return NoContent();
		}

		[HttpDelete("{id}")]
		public IActionResult DeletaEndereco(int id)
		{
			Endereco endereco = _context.Enderecos.FirstOrDefault(endereco => endereco.Id == id);
			if (endereco == null)
			{
				return NotFound();
			}

			_context.Remove(endereco);
			_context.SaveChanges();

			return NoContent();
		}
	}
}
