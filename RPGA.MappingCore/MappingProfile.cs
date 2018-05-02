using AutoMapper;
using RPGA.Data.Models;
using RPGA.Logic.Models.Implementations.Character.Classes;

namespace RPGA.Relationships
{
	public class MappingProfile : Profile
	{
		public MappingProfile()
		{
			//Logical to Presentation
			//CreateMap<ICharacter, CharacterVM>();
			//CreateMap<IAttack, AttackVM>();
			//CreateMap<ISpecialFeature, SpecialFeatureVM>();

			//Logical to Data
			CreateMap<Class_Barbarian, CharacterDM>().ForMember(dest => dest.ID, opts => opts.Ignore());
			CreateMap<Class_Bard, CharacterDM>().ForMember(dest => dest.ID, opts => opts.Ignore());
			CreateMap<Class_Cleric, CharacterDM>().ForMember(dest => dest.ID, opts => opts.Ignore());
			CreateMap<Class_Druid, CharacterDM>().ForMember(dest => dest.ID, opts => opts.Ignore());
			CreateMap<Class_Fighter, CharacterDM>().ForMember(dest => dest.ID, opts => opts.Ignore());
			CreateMap<Class_Monk, CharacterDM>().ForMember(dest => dest.ID, opts => opts.Ignore());
			CreateMap<Class_Paladin, CharacterDM>().ForMember(dest => dest.ID, opts => opts.Ignore());
			CreateMap<Class_Ranger, CharacterDM>().ForMember(dest => dest.ID, opts => opts.Ignore());
			CreateMap<Class_Rogue, CharacterDM>().ForMember(dest => dest.ID, opts => opts.Ignore());
			CreateMap<Class_Sorcerer, CharacterDM>().ForMember(dest => dest.ID, opts => opts.Ignore());
			CreateMap<Class_Warlock, CharacterDM>().ForMember(dest => dest.ID, opts => opts.Ignore());
			CreateMap<Class_Wizard, CharacterDM>().ForMember(dest => dest.ID, opts => opts.Ignore());
		}
	}
}