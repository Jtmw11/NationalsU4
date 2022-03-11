
singleton TSShapeConstructor(Forest_interior_group_1Dae)
{
   baseShape = "./forest_interior_group_1.dae";
};

function Forest_interior_group_1Dae::onLoad(%this)
{
   %this.addImposter("25", "8", "0", "0", "128", "1", "0");
}
