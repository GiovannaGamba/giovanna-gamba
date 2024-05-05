using AGP.MultiSearch.API.Dtos;

namespace AGP.MultiSearch.API.Services;

public interface IMainService
{
    public SearchObjectsDto Search(string textToSearch);
}
