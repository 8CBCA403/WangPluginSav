using System.Collections.Generic;

namespace WangPluginSav;

internal class SVClothesConstants
{
	public static readonly Block KFashionUnlockedBag = (1567588624u, "Bag.bin");

	public static readonly Block KFashionUnlockedEyewear = (3416395477u, "Eyewear.bin");

	public static readonly Block KFashionUnlockedFootwear = (35759640u, "Footwear.bin");

	public static readonly Block KFashionUnlockedGloves = (1477863345u, "Gloves.bin");

	public static readonly Block KFashionUnlockedHeadwear = (2248988923u, "Headwear.bin");

	public static readonly Block KFashionUnlockedLegwear = (3515228718u, "Legwear.bin");

	public static readonly Block KFashionUnlockedPhoneCase = (3976906357u, "PhoneCase.bin");

	public static readonly IReadOnlyList<Block> ClothesBlocks = new List<Block> { KFashionUnlockedBag, KFashionUnlockedEyewear, KFashionUnlockedFootwear, KFashionUnlockedGloves, KFashionUnlockedHeadwear, KFashionUnlockedLegwear, KFashionUnlockedPhoneCase };
}
