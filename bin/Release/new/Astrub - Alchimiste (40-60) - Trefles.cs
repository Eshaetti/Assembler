// Script Convertie par Eshaetti avec un sample de trajet Retn fait par Melionor

using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using Retn.Game;
using Retn.Game.Pathing;
using Retn.Game.Script;
using Retn.Protocol.Game.Enums;

namespace Retn.Script;

public class sample(IScript script)
{
    private IScriptArena Arena => script.Arena;
    private IScriptBank Bank => script.Bank;
    private IScriptCharacter Character => script.Character;
    private IScriptChat Chat => script.Chat;
    private IScriptCommon Common => script.Common;
    private IScriptCraft Craft => script.Craft;
    private IScriptData Data => script.Data;
    private IScriptExchange Exchange => script.Exchange;
    private IScriptExchangeSale ExchangeSale => script.ExchangeSale;
    private IScriptFight Fight => script.Fight;
    private IScriptHunt Hunt => script.Hunt;
    private IScriptInventory Inventory => script.Inventory;
    private IScriptJob Job => script.Job;
    private IScriptMap Map => script.Map;
    private IScriptMount Mount => script.Mount;
    private IScriptNpc Npc => script.Npc;
    private IScriptQuest Quest => script.Quest;

   [Handler]
   public Task OnLoadedAsync()
   {
      Bank.SetWeightLimit(85, 95);

      return Task.CompletedTask;
   }


   [Handler]
   public async Task OnMoveAsync(int count)
   {
      var items = Inventory.GetItems([00000]); // OpenBag à remplir pour un trajet récolte

      foreach(var item in items)
      {
         await Inventory.UseAsync(item, item.Quantity);
      }

      await script.Map.GatherAsync([000, 111, 222, 333]); // Ligne à conserver pour activer la récolte ( ajuster les id en fonction )
                                                         // ou à commenter pour un trajet sans récolte ou un trajet fight par exemple à votre convenance.
      var move1 = new Dictionary < long,
         List < Func < Task >>>
         {

         };

      if (move1.TryGetValue(Map.Id, out
            var actions1))
      {
         await actions1[(count - 1) % actions1.Count]();
         return;
      }

      var move = new Dictionary < (short, short),
         List < Func < Task >>>
         {
            [(0, 0)] = [
               async () =>
               {
                  await Map.UseZaapAsync(0000000); // Zaap à remplir
               },
            ],

[(5,-18)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Down); },
],
[(5,-17)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Down); },
],
[(5,-16)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Down); },
],
[(5,-15)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Down); },
],
[(5,-14)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Down); },
],
[(5,-12)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Down); },
],
[(5,-13)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Down); },
],
[(5,-11)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Right); },
],
[(6,-11)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Down); },
],
[(6,-10)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Down); },
],
[(6,-9)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Left); },
],
[(5,-9)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Up); },
],
[(5,-10)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Left); },
],
[(4,-11)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Left); },
],
[(3,-11)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Down); },
],
[(4,-10)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Up); },
],
[(3,-10)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Left); },
],
[(2,-10)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Left); },
],
[(1,-10)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Up); },
],
[(1,-11)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Right); },
],
[(2,-11)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Up); },
],
[(2,-12)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Up); },
],
[(2,-13)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Up); },
],
[(2,-14)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Up); },
],
[(2,-15)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Left); },
],
[(1,-15)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Left); },
],
[(0,-15)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Left); },
],
[(-1,-15)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Left); },
],
[(-2,-15)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Left); },
],
[(-3,-15)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Up); },
],
[(-3,-16)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Right); },
],
[(-2,-16)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Right); },
],
[(-1,-16)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Right); },
],
[(-2,-18)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Right); },
],
[(-1,-18)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Right); },
],
[(-3,-18)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Right); },
],
[(0,-16)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Up); },
],
[(0,-17)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Left); },
],
[(-1,-17)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Left); },
],
[(-2,-17)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Left); },
],
[(-3,-17)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Up); },
],
[(0,-18)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Up); },
],
[(0,-19)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Left); },
],
[(-1,-19)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Left); },
],
[(-2,-19)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Left); },
],
[(-3,-19)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Up); },
],
[(-2,-20)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Right); },
],
[(-1,-20)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Right); },
],
[(-3,-20)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Right); },
],
[(0,-20)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Up); },
],
[(0,-21)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Left); },
],
[(-1,-21)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Left); },
],
[(-2,-21)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Left); },
],
[(-3,-21)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Up); },
],
[(-3,-22)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Right); },
],
[(-2,-22)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Right); },
],
[(-1,-22)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Right); },
],
[(0,-22)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Up); },
],
[(0,-23)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Right); },
],
[(1,-23)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Right); },
],
[(2,-23)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Right); },
],
[(3,-23)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Right); },
],
[(4,-23)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Down); },
],
[(4,-22)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Down); },
],
[(4,-21)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Down); },
],
[(4,-19)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Down); },
],
[(4,-18)] = [
  async () => { await Map.ChangeToAsync(ChangeMapSide.Right); },
],



         };

      if (move.TryGetValue(Map.Coords, out
            var actions))
      {
         await actions[(count - 1) % actions.Count]();
         return;
      }

      await Map.GoToHavenBagAsync();
   }
    [Handler]
   public async Task OnMoveBankAsync()
   {
      if (Map.Id == 214696968)
      {
         await Npc.SpeakToAsync(6374);
         return;
      }

      switch (Map.Coords)
      {
         case (0, 0):
            await Map.UseZaapAsync(212861955); // Zaap Brakmar
            break;
         case (-26, 37):
         case (-26, 36):
            await Map.AutoTripAsync(214696968); // Intérieur Banque Brakmar
            break;
         default:
            await Map.GoToHavenBagAsync();
            break;
      }
   }

   [Handler]
   public async Task OnNpcDialogOpenedAsync(NpcQuestion question)
   {
      if (question.MessageId == 47040)
      {
         await Npc.AnswerAsync(question.Replies[0]);
      }
   }

   [Handler]
   public async Task OnBankOpenedAsync()
   {
      await Bank.DepositAsync(DepositType.Resources); // Resources pour déposer uniquement ces dernière au Everything pour tout déposer.

      await Bank.TakeKamasAsync(Bank.Kamas);

      await Bank.LeaveAsync();
   }

   [Handler]
   public async Task OnFightPosAsync()
   {
      await Fight.SetBonusAsync(ChallengeBonusEnum.ChallengeDropBonus);

      await Fight.SetPositionAsync(FightPosition.Furthest);
   }

   [Handler]
   public async Task OnFightTurnAsync()
   {
      switch (Character.Breed)
      {
         case PlayableBreedEnum.Ecaflip:

            await Fight.ExecuteAsync(
               [
                  new FightActionMove(FightMove.Nearest), // Déplacement
                  new FightActionCast(12869, CastTarget.Invoke), // Caresse  Invocatrice
                  new FightActionCast(12850, CastTarget.Me), // Contrecoup
                  new FightActionCast(12845, CastTarget.Me), // Roue de la Fortune 
                  new FightActionCast(12841, CastTarget.Enemy), // Pile Ou Face
                  new FightActionCast(12841, CastTarget.Enemy), // Pile Ou Face
                  new FightActionFinishTurn() // Passe
               ]);

            break;

         case PlayableBreedEnum.Sadida:

            await Fight.ExecuteAsync(
               [
                  new FightActionMove(FightMove.Nearest), // Déplacement
                  new FightActionCast(13564, CastTarget.Invoke), // Folle
                  new FightActionCast(13516, CastTarget.Enemy), // Ronce
                  new FightActionCast(13516, CastTarget.Enemy), // Ronce
                  new FightActionFinishTurn() // Passe
               ]);

            break;

         case PlayableBreedEnum.Feca:

            await Fight.ExecuteAsync(
               [
                  new FightActionMove(FightMove.Nearest), // Déplacement
                  new FightActionCast(12981, CastTarget.Me), // Rempart
                  new FightActionCast(13007, CastTarget.Enemy), // Houlette
                  new FightActionCast(12993, CastTarget.Enemy), // Lethargie
                  new FightActionCast(12978, CastTarget.Enemy), // Langueur
                  new FightActionFinishTurn() // Passe
               ]);

            break;

         case PlayableBreedEnum.Sacrieur:

            await Fight.ExecuteAsync(
               [
                    new FightActionMove(FightMove.Nearest),
                    new FightActionCast(12744, CastTarget.Invoke), // Épée Vorace
                    new FightActionCast(12746, CastTarget.Enemy), // Ravage
                    new FightActionCast(12725, CastTarget.Enemy), // Supplice
                    new FightActionCast(12725, CastTarget.Enemy), // Supplice
                    new FightActionFinishTurn()
               ]);

            break;

         case PlayableBreedEnum.Enutrof:

            await Fight.ExecuteAsync(
               [
                  new FightActionMove(FightMove.Nearest), // Déplacement
                  new FightActionCast(13328, CastTarget.Invoke), // Sac Animé
                  new FightActionCast(13338, CastTarget.Enemy), // Lancer de Pièces
                  new FightActionCast(13338, CastTarget.Enemy), // Lancer de Pièces
                  new FightActionFinishTurn() // Passe
               ]);

            break;
      }
   }

   [Handler]
   public Task OnInventoryWeightChangedAsync()
   {
      if (Character.IsInBank)
      {
         Bank.SetWeightLimit(85, 95);
      }

      return Task.CompletedTask;
   }
}