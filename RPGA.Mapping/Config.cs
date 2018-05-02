using AutoMapper;
using RPGA.Domain;
using RPGA.ViewModels;
using System;

namespace RPGA.Mapping
{
	public class Config
	{
		public Config()
		{
			var config = new MapperConfiguration(cfg => cfg.CreateMap<CharacterDM, CharacterVM>());
		}
	}
}