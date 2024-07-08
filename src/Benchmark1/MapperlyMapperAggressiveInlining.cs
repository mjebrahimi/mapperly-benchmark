using Mapperly_Benchmark.Benchmark2.Models;
using Riok.Mapperly.Abstractions;

namespace Mapperly_Benchmark.Benchmark2;

[Mapper]
public static partial class MapperlyMapperAggressiveInlining
{
    public static partial ClassSpotifyAlbum MapToClass(SpotifyAlbumDto spotifyAlbumDto);

    public static partial StructSpotifyAlbum MapToStruct(SpotifyAlbumDto spotifyAlbumDto);
}