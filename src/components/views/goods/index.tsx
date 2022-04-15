import { FC } from "react";
import { IconArrow } from "../../icons/arrow";
import { BreadCrumbs } from "@layout/bread-crumbs";
import { CardsSection } from "./sections/cards";
import { FilterSection } from "./sections/filter";
import { SortSection } from "./sections/sort";

const bread_data = [
   {
      name: "Товари",
      link: "/goods"
   },
   {
      name: "Одяг",
      link: "/goods"
   },
   {
      name: "Жіночий",
      link: "/goods"
   },
   {
      name: "Футболки",
      link: "/goods"
   }
];

export const GoodsView: FC = () => {
   return (
      <div className="flex py-4 gap-8">
         <div className="w-60">
            <FilterSection />
         </div>
         <div className="flex-1">
            <div className="flex justify-between items-center">
               <BreadCrumbs options={bread_data} />
               <SortSection />
            </div>
            <div>
               <CardsSection />
               <div className="flex justify-center mt-8">
                  <button className="bg-black leading-10 text-white px-8 flex items-center gap-2">
                     <span>Далі</span>
                     <IconArrow className="h-4 w-4" />
                  </button>
               </div>
            </div>
         </div>
      </div>
   );
};