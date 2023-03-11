using System.Collections.Generic;

namespace WangPluginSav;

internal class LAClothesConstants
{
	public static readonly Block KFashionUnlockedHat = (987466392u, "Hat.bin");

	public static readonly Block KFashionUnlockedTop = (2195029783u, "Top.bin");

	public static readonly Block KFashionUnlockedBottoms = (296976073u, "Bottoms.bin");

	public static readonly Block KFashionUnlockedOverall = (1166348434u, "Overall.bin");

	public static readonly Block KFashionUnlockedShoes = (1667914429u, "Shoes.bin");

	public static readonly Block KFashionUnlockedGlasses = (1487626803u, "Glasses.bin");

	public static readonly IReadOnlyList<Block> ClothesBlocks = new List<Block> { KFashionUnlockedHat, KFashionUnlockedTop, KFashionUnlockedBottoms, KFashionUnlockedOverall, KFashionUnlockedShoes, KFashionUnlockedGlasses };
}
