import { FC, useState } from "react";
import { FilterGroup } from "./filter-group";

export const FilterSection: FC = () => {

   const [filters, setFilters] = useState<{ [key: string]: { [key: string]: any } }>({});

   const handleChange = (name: string, values: { [key: string]: any }) => {
      setFilters({
         ...filters,
         [name]: values
      });
   }

   return (
      <div className="space-y-4">
         <FilterGroup onChange={(values) => handleChange("color", values)} label="Колір" options={[
            { name: "Білий", value: "white" },
            { name: "Чорний", value: "black" },
            { name: "Синій", value: "navy" },
            { name: "Рожевий", value: "pink" },
         ]} />
         <FilterGroup onChange={(values) => handleChange("material", values)} label="Матеріал" options={[
            { name: "Бавовна", value: "cotton" },
            { name: "Шифон", value: "chiffon" },
            { name: "Волокно", value: "fiber" },
            { name: "Текстиль", value: "textile" },
         ]} />
         <FilterGroup onChange={(values) => handleChange("brand", values)} label="Бренд" options={[
            { name: "Zara", value: "zara" },
            { name: "Puma", value: "puma" },
            { name: "H & M", value: "h&m" },
            { name: "Nike", value: "nike" },
         ]} />
      </div>
   );
};