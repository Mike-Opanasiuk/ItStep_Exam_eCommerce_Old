import { FC } from "react";
import { Form } from "../../base/form";
import { RenderIf } from "../../base/render-if";
import { IconEdit } from "../../icons/edit";
import { useSignLogic } from "./logic";

export const SignView: FC = () => {

   const { enterModeCode, enterModePhone, handleEditPhone, handleFinishForm } = useSignLogic();

   return (
      <div className="flex h-full">
         <div className="m-auto border py-8 px-12">
            <Form onFinish={handleFinishForm}>
               <div className="flex flex-col">
                  <span className="text-3xl">Вхід в аккаунт</span>
                  <span className="text mt-8 text-center">Введіть номер телефону:</span>
                  <div className="w-60 relative">
                     <input
                        required
                        autoComplete="off"
                        disabled={enterModeCode}
                        name="phone"
                        type="text"
                        placeholder="+380 93 4567 890"
                        className="w-full outline-none border-b mt-4 text-center leading-10 text-gray-700"
                     />
                     <RenderIf condition={enterModeCode}>
                        <div
                           onClick={handleEditPhone}
                           className="absolute bottom-0 right-5 w-4 h-10 leading-10 flex items-center cursor-pointer"
                        >
                           <IconEdit className="h-4 w-4 text-gray-800" />
                        </div>
                     </RenderIf>
                  </div>
                  <RenderIf condition={enterModeCode}>
                     <span className="text mt-4 text-center">Введіть код з смс:</span>
                     <input
                        autoComplete="off"
                        name="code"
                        type="text"
                        placeholder="XXXX"
                        maxLength={4}
                        className="w-full outline-none border-b mt-4 text-center leading-10 text-gray-700"
                     />
                  </RenderIf>
                  <button className="mt-8 bg-black text-white py-4">
                     {enterModePhone && "Надіслати"}
                     {enterModeCode && "Підтвердити"}
                  </button>
               </div>
            </Form>
         </div>
      </div>
   );
}